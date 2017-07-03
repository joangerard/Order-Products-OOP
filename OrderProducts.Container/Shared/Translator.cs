


using Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProducts
{
    public class Interpreter<TObject>
    {
        string options;
        IFactoryObjectPropertyComparer<TObject> factoryObjectPropertyComparer;
        FatoryObjectPropertyOrderDecider<TObject> factoryOrderDeciders;
        string[] properties;
        string[] orderings;
        char orderSeparator;
        char propertySeparator;

        public Interpreter(IFactoryObjectPropertyComparer<TObject> factoryObjectPropertyComparer, string defaultOptions, char orderSeparator = '-', char propertySeparator = ',')
        {
            this.options = defaultOptions;
            this.factoryObjectPropertyComparer = factoryObjectPropertyComparer;
            this.factoryOrderDeciders = new FatoryObjectPropertyOrderDecider<TObject>();
            this.orderSeparator = orderSeparator;
            this.propertySeparator = propertySeparator;
        }

        public void SetFactoryObjectPropertyComparer(IFactoryObjectPropertyComparer<TObject> factoryObjectPropertyComparer)
        {
            this.factoryObjectPropertyComparer = factoryObjectPropertyComparer;
        }

        public List<IObjectOrderDecider<TObject>> Translate(string options)
        {
            this.options = options;
            Parse(options);

            IObjectPropertyComparer<TObject> type;
            List<IObjectOrderDecider<TObject>> orders = new List<IObjectOrderDecider<TObject>>();

            for (int i = 0; i < properties.Count(); i++)
            {
                factoryObjectPropertyComparer.SetOption(properties[i]);
                type= factoryObjectPropertyComparer.Create();
                factoryOrderDeciders.SetOption(orderings[i]);
                factoryOrderDeciders.SetType(type);
                orders.Add(factoryOrderDeciders.Create());
            }

            return orders;
        }

        private void Parse(string options)
        {
            properties = options.Split(propertySeparator);
            orderings = new string[properties.Count()];
            for (int i = 0; i < properties.Count(); i++)
            {
                orderings[i] = properties[i].Split(orderSeparator).Length > 1 ? properties[i].Split(orderSeparator)[1] : "A";
                properties[i] = properties[i].Split(orderSeparator)[0];
            }
        }
    }
}
