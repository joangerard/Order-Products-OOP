
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    public static class ListHelper<TObject>
    {

        public static void Order(List<TObject> list,List<IObjectOrderDecider<TObject>> orderDeciders)
        {
            OrderByBubble(list,orderDeciders);
        }

        private static void OrderByBubble(List<TObject> list,List<IObjectOrderDecider<TObject>> orderDeciders)
        {
            TObject t;
            for (int a = 1; a < list.Count(); a++)
                for (int b = list.Count() - 1; b >= a; b--)
                {
                    if (Comparer(list[b - 1], list[b], orderDeciders))
                    {
                        t = list[b - 1];
                        list[b - 1] = list[b];
                        list[b] = t;
                    }
                }
        }

        private static bool Comparer(TObject o1, TObject o2, List<IObjectOrderDecider<TObject>> orderDeciders)
        {
            int i;
            bool response = false;
            
            for (i=1; i <= orderDeciders.Count();i++ )
            {
                response = response || ComparerHelper(o1, o2, orderDeciders.GetRange(0, i));
            }

            return response;
        }

        private static bool ComparerHelper(TObject o1, TObject o2, List<IObjectOrderDecider<TObject>> list)
        {
            bool response = true;
            for (int i = 0; i < list.Count() - 1; i++)
            {
                response = list[i].EqualValues(o1, o2) && response;
            }
            return list[list.Count() - 1].OrderDecided(o1, o2) && response;
        }
    }
}
