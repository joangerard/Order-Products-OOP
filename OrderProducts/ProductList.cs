using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProducts
{
    class ProductList
    {
        List<Product> products;

        public ProductList() 
        {
            products = new List<Product>();
        }

        public void Add(Product p) 
        {
            products.Add(p);
        }

        public void Order(IOrderManager orderValue1, IOrderManager orderValue2, IOrderManager orderValue3) 
        {
            OrderByBubble(orderValue1,orderValue2,orderValue3);
        }

        public void Show() 
        {
            products.ForEach(p=>p.Show());
        }

        //TODO: Refactor, break first principle of SOLID
        private void OrderByBubble(IOrderManager orderValue1, IOrderManager orderValue2, IOrderManager orderValue3)
        {
            Product t;
            for (int a = 1; a < products.Count(); a++)
                for (int b = products.Count() - 1; b >= a; b--)
                {
                    if (Comparer(products[b - 1], products[b], orderValue1, orderValue2, orderValue3))
                    {
                        t = products[b - 1];
                        products[b - 1] = products[b];
                        products[b] = t;
                    }
                }
        }


        //TODO: Refactor, break first principle of SOLID
        private bool Comparer(Product product1, Product product2, IOrderManager orderValue1, IOrderManager orderValue2, IOrderManager orderValue3)
        {
            return orderValue1.DifferentValues(product1, product2) ||
                    (orderValue1.EqualValues(product1, product2) && orderValue2.DifferentValues(product1, product2)) ||
                    (orderValue1.EqualValues(product1, product2) && orderValue2.EqualValues(product1, product2) && orderValue3.DifferentValues(product1, product2));
        }
    }
}
