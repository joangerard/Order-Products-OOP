
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    public abstract class ObjectListBase<TObject> : List<TObject>
    {

        public void Order(List<IObjectOrderDecider<TObject>> orderDeciders)
        {
            OrderByBubble(orderDeciders);
        }

        private void OrderByBubble(List<IObjectOrderDecider<TObject>> orders)
        {
            TObject t;
            for (int a = 1; a < this.Count(); a++)
                for (int b = this.Count() - 1; b >= a; b--)
                {
                    if (Comparer(this[b - 1], this[b], orders, 1))
                    {
                        t = this[b - 1];
                        this[b - 1] = this[b];
                        this[b] = t;
                    }
                }
        }

        private bool Comparer(TObject product1, TObject product2, List<IObjectOrderDecider<TObject>> orders, int level)
        {
            if (level == orders.Count())
            {
                return ComparerHelper(product1, product2, orders);
            }
            level++;
            return Comparer(product1, product2, orders, level) || ComparerHelper(product1, product2, orders.GetRange(0, orders.Count() - 1));

        }

        private bool ComparerHelper(TObject product1, TObject product2, List<IObjectOrderDecider<TObject>> list)
        {
            bool response = true;
            for (int i = 0; i < list.Count() - 1; i++)
            {
                response = list[i].EqualValues(product1, product2) && response;
            }
            return list[list.Count() - 1].OrderDecided(product1, product2) && response;
        }
    }
}
