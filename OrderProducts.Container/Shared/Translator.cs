


using Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProducts
{
    public class Interpreter<T>
    {
        string options;
        IFactoryObjectPropertyComparer<T> factoryObjectPropertyComparer;
        FatoryObjectPropertyOrderDecider<T> factoryOrderDeciders;
        string[] properties;
        string[] orderings;
        char orderSeparator;
        char propertySeparator;

        public Interpreter(IFactoryObjectPropertyComparer<T> factoryObjectPropertyComparer, string defaultOptions, char orderSeparator = '-', char propertySeparator = ',')
        {
            this.options = defaultOptions;
            this.factoryObjectPropertyComparer = factoryObjectPropertyComparer;
            this.factoryOrderDeciders = new FatoryObjectPropertyOrderDecider<T>();
            this.orderSeparator = orderSeparator;
            this.propertySeparator = propertySeparator;
        }

        public void SetFactoryObjectPropertyComparer(IFactoryObjectPropertyComparer<T> factoryObjectPropertyComparer)
        {
            this.factoryObjectPropertyComparer = factoryObjectPropertyComparer;
        }

        public List<IObjectOrderDecider<T>> Translate(string options)
        {
            this.options = options;
            Parse(options);

            IObjectPropertyComparer<T> type;
            List<IObjectOrderDecider<T>> orders = new List<IObjectOrderDecider<T>>();

            for (int i = 0; i < properties.Count(); i++)
            {
                type = factoryObjectPropertyComparer.Create(properties[i]);
                orders.Add(factoryOrderDeciders.Create(orderings[i], type));
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
