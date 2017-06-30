using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    public abstract class BoxComponent
    {
        public string NameComponent { get { return this.NameComponent; } }
        public string DescriptionComponent { get { return this.DescriptionComponent; } }

        public virtual void Add(BoxComponent containerComponent)
        {
            throw new InvalidOperationException();
        }

        public virtual void Remove(BoxComponent containerComponent)
        {
            throw new InvalidOperationException();
        }

        public virtual BoxComponent GetChild(int i)
        {
            throw new InvalidOperationException();
        }

        public virtual void Print()
        {
            throw new InvalidOperationException();
        }
    }
}
