using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    class MenuItem:MenuComponent
    {
        public string Option { get; set; }
        public string Description { get; set; }
        private IViewer _viewer;

        public MenuItem(string option, string description,IViewer viewer)
        {
            this.Option = option;
            this.Description = description;
            this._viewer = viewer;
        }

        public override void ShowInformation()
        {
            _viewer.Show(String.Format("{0} {1}", Option, Description));
        }
    }
}
