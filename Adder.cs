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
        private const int START_X = 0;
        private const int START_Y = 220;
        private const int END_X = 0;
        private const int END_Y = 330;
        private static Image GetTemplate()
        {
            return Image.FromFile("template.jpg");
        }


        public static Image AddHeaderAndFooter(Image image)
        {
            Image template = GetTemplate();
            Point startPoint;
            Size imageSize;
            float initialRatio;

            Graphics graphics = Graphics.FromImage(template);

            startPoint = new Point(START_X, START_Y);
            imageSize = new Size(image.Width + END_X, image.Height - END_Y - START_Y);

            //repair aspect ratio
            initialRatio = (float)image.Width / image.Height;
            imageSize.Width = (int)((image.Height - END_Y - START_Y) * initialRatio);

            graphics.DrawImage(image, new Rectangle(startPoint, imageSize));

            return template;
        }

    }
}

