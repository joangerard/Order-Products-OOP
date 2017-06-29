using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProducts
{
    public class Translator
    {
        string options;
        FactoryType factoryType;
        FactoryOrder factoryOrder;
        string[] properties;
        string[] orderings;
        int numberOfProperties;

        public Translator(int numberOfProperties)
        {
            this.options = "1-A";
            this.factoryType = new FactoryType();
            this.factoryOrder = new FactoryOrder();
            this.numberOfProperties = numberOfProperties;
        }

        public List<IOrderManager> Translate(string options)
        {
            this.options = options;
            Parse(options);

            IPropertyManager type;
            List<IOrderManager> orders = new List<IOrderManager>();

            for (int i = 0; i < properties.Count(); i++)
            {
                factoryType.SetOption(properties[i]);
                type= factoryType.Create();
                factoryOrder.SetOption(orderings[i]);
                factoryOrder.SetType(type);
                orders.Add(factoryOrder.Create());
            }

            return orders;
        }

        private void Parse(string options)
        {
            properties = options.Split(',');
            orderings = new string[properties.Count()];
            for (int i = 0; i < properties.Count(); i++)
            {
                orderings[i] = properties[i].Split('-').Length > 1 ? properties[i].Split('-')[1] : "A";
                properties[i] = properties[i].Split('-')[0];
            }
        }
    }
}
