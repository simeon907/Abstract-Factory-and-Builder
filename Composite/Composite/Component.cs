using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class Component
    {
        protected string title;

        public Component(string title)
        {
            this.title = title;
        }

        public virtual void Add(Component c) { }
        public virtual void Remove(Component c) { }
        public abstract void Play(int depth);
    }
}
