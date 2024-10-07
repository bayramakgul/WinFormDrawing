using System.Drawing;

namespace DxfLibrary.Entity
{
    public class DPoint
    {
        public double X { get; set; }
        public double Y { get; set; }

        public DPoint(double x, double y)
        {
            X = x;
            Y = y;
        }

        public PointF ToPointF()
        {
            return new PointF((float)X, (float)Y);
        }

        public DPoint Offset(double dx, double dy)
        {
            return new DPoint(X - dx, Y - dy);
        }

    }
}
