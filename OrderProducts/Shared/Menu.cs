using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    public class Menu:MenuComponent
    {
        List<MenuComponent> ContainerComponents;
        public string Name { get; set; }
        public string Description { get; set; }

        private IViewer Viewer;

        public Menu(string name, string description,IViewer viewer)
        {
            this.Name = name;
            this.Description = description;
            this.ContainerComponents = new List<MenuComponent>();
            this.Viewer = viewer;
        }

        public override void Add(MenuComponent containerComponent)
        {
            ContainerComponents.Add(containerComponent);
        }

        public override void Remove(MenuComponent containerComponent)
        {
            ContainerComponents.Remove(containerComponent);
        }

        public override MenuComponent GetChild(int i)
        {
            return ContainerComponents.ElementAt(i);
        }

        public override void Show()
        {
            this.Viewer.Show(this.Name + " " + this.Description);
            this.Viewer.Show("-----------------------------");
            
            foreach (var item in ContainerComponents)
            {
                item.Show();
            }
            this.Viewer.Show("");
        }

    }
}
