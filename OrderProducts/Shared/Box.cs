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

        public Box(string name, string description)
        {
            this.Name = name;
            this.Description = description;
            this.ContainerComponents = new List<BoxComponent>();
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

        public override void Print()
        {
            Console.WriteLine(this.Name);
            Console.WriteLine(this.Description);
            Console.WriteLine("---------------------------");

            foreach (var item in ContainerComponents)
            {
                item.Print();
            }
            
        }

    }
}
