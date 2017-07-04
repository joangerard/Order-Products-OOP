


using Container;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    public class Interpreter<T>
    {
        string options;

        IPropertyComparerFactory<T> propertyComparerFactory;

        string[] optionProperties;
        string[] optionOrders;
        char orderSeparator;
        char propertySeparator;

        public Interpreter(IPropertyComparerFactory<T> propertyComparerFactory, string defaultOptions, char orderSeparator = '-', char propertySeparator = ',')
        {
            this.options = defaultOptions;
            this.propertyComparerFactory = propertyComparerFactory;
            this.orderSeparator = orderSeparator;
            this.propertySeparator = propertySeparator;
        }


        public List<IComparer<T>> Translate(string options)
        {
            this.options = options;
            Parse(options);

            List<IComparer<T>> comparers = new List<IComparer<T>>();
            for (int i = 0; i < optionProperties.Count(); i++)
            {
                IComparer<T> comparer = propertyComparerFactory.Create(optionOrders[i], optionProperties[i]);
                comparers.Add(comparer);
            }

            return comparers;
        }

        private void Parse(string options)
        {
            optionProperties = options.Split(propertySeparator);
            optionOrders = new string[optionProperties.Count()];
            for (int i = 0; i < optionProperties.Count(); i++)
            {
                optionOrders[i] = optionProperties[i].Split(orderSeparator).Length > 1 ? optionProperties[i].Split(orderSeparator)[1] : "A";
                optionProperties[i] = optionProperties[i].Split(orderSeparator)[0];
            }
        }
    }
}
