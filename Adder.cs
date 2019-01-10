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
        private static Image GetHeader()
        {
            return Image.FromFile("header.jpg");
        }

        private static Image GetFooter()
        {
            return Image.FromFile("footer.jpg");
        }

        public static Image AddHeaderAndFooter(Image image)
        {
            Image img = image;

            return img;
        }

    }
}

