using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Alumni.MooseStuff
{
    class Texture
    {
        public const string AssetsPath = "Assets\\";

        public readonly string Name;

        public Image Image;

        public Texture(string Name)
        {
            this.Name = Name;
            try
            {
                Image = Image.FromFile(AssetsPath + Name);
            }
            catch
            {
                Image = null;
                Console.WriteLine("Something went wrong loading image from path: \"" + Name + "\"");
            }
        }
    }
}
