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

        public void Order(List<IOrderManager> orders)
        {
            OrderByBubble(orders);
        }

        public void Show() 
        {
            products.ForEach(p=>p.Show());
        }

        private void OrderByBubble(List<IOrderManager> orders)
        {
            Product t;
            for (int a = 1; a < products.Count(); a++)
                for (int b = products.Count() - 1; b >= a; b--)
                {
                    if (Comparer(products[b - 1], products[b], orders,1))
                    {
                        t = products[b - 1];
                        products[b - 1] = products[b];
                        products[b] = t;
                    }
                }
        }

        private bool Comparer(Product product1, Product product2, List<IOrderManager> orders,int level)
        {
            if (level == orders.Count())
            {
                return ComparerHelper(product1,product2,orders);
            }
            level++;
            return Comparer(product1, product2, orders, level) || ComparerHelper(product1, product2, orders.GetRange(0,orders.Count()-1));
            
        }

        private bool ComparerHelper(Product product1, Product product2, List<IOrderManager> list)
        {
            bool response = true;
            for (int i = 0; i < list.Count()-1; i++)
            {
                response = list[i].EqualValues(product1, product2) && response;
            }
            return list[list.Count() - 1].DifferentValues(product1, product2) && response;
        }
    }
}
