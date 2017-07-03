using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    public abstract class MenuComponent
    {
        private string _optionComponent;
        private string _descriptionComponent;
        public string OptionComponent { get { return this._optionComponent; } set { this._optionComponent = value; } }
        public string DescriptionComponent { get { return this._descriptionComponent; } set { this._descriptionComponent = value; } }

        public virtual void Add(MenuComponent containerComponent)
        {
            throw new InvalidOperationException();
        }

        public virtual void Remove(MenuComponent containerComponent)
        {
            throw new InvalidOperationException();
        }

        public virtual MenuComponent GetChild(int i)
        {
            throw new InvalidOperationException();
        }

        public virtual void ShowInformation()
        {
            throw new InvalidOperationException();
        }
    }
}
