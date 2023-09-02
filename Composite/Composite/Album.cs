using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Composite
{
    public class Album : Component
    {
        List<Component> tracks = new List<Component>(); 
        public Album(string title) : base(title)
        {
        }

        public override void Add(Component c)
        {
            tracks.Add(c);
        }

        public override void Remove(Component c)
        {
            tracks.Remove(c);
        }

        public override void Play(int depth)
        {
            Console.WriteLine(new string('-', depth) + title + " is playing");

            foreach (Component component in tracks)
            {
                component.Play(depth + 2);
            }
        }
    }
}
