using System.Drawing;

namespace Tools4Libraries.Slider
{
    public static class GraphicsExtensionMethods
    {
        public static void DraxPixel(this Graphics graphics, Brush brush, int x, int y)
        {
            graphics.FillRectangle(brush, x, y, 1, 1);
        }
    }
}
