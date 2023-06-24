using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Magazine
    {
        static Lazy<Magazine> instance = new Lazy<Magazine>(() => new Magazine());
        public static Magazine Instance
        {
            get
            {
                return instance.Value;
            }
        }
        protected Magazine() { }

        public void Comment(string text)
        {
            if (text != null)
            {
                using (TextWriter tw = File.AppendText("SavedList.txt"))
                {
                    tw.WriteLine(text);
                }
            }
        }
    }
}
