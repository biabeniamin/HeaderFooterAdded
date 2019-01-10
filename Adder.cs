using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeaderFooterAdded
{
    public static class Adder
    {
        private static Image GetTemplate()
        {
            return Image.FromFile("template.jpg");
        }


        public static Image AddHeaderAndFooter(Image image)
        {
            Image template = GetTemplate();


            return template;
        }

    }
}

