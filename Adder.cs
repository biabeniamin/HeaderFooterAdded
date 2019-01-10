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

            Graphics graphics = Graphics.FromImage(template);

            graphics.DrawImage(image, new Rectangle(new Point(0,150), new Size(image.Width,600)));

            return template;
        }

    }
}

