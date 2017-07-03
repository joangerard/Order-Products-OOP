using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    public class Box:BoxComponent
    {
        List<BoxComponent> ContainerComponents;
        public string Name { get; set; }
        public string Description { get; set; }

        private IViewer Viewer;

        public Box(string name, string description,IViewer viewer)
        {
            this.Name = name;
            this.Description = description;
            this.ContainerComponents = new List<BoxComponent>();
            this.Viewer = viewer;
        }

        public override void Add(BoxComponent containerComponent)
        {
            ContainerComponents.Add(containerComponent);
        }

        public override void Remove(BoxComponent containerComponent)
        {
            ContainerComponents.Remove(containerComponent);
        }

        public override BoxComponent GetChild(int i)
        {
            return ContainerComponents.ElementAt(i);
        }

        public override void ShowInformation()
        {
            this.Viewer.Show(this.Name);
            this.Viewer.Show(this.Description);
            this.Viewer.Show("-----------------------------");

            foreach (var item in ContainerComponents)
            {
                item.ShowInformation();
            }
            
        }

    }
}
