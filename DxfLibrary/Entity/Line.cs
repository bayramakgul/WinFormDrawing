using System;
using System.Drawing;
namespace DxfLibrary.Entity
{
    public class Line : BaseEntity
    {
        public DPoint SP {  get; set; } // Start point
        public DPoint EP { get; set; } // End point

        public Line(PointF p1, PointF p2)
        {
            SP = new DPoint(p1.X, p1.Y);
            EP = new DPoint(p2.X, p2.Y);
        }

        public Line(DPoint p1, DPoint p2)
        {
            SP = new DPoint(p1.X, p1.Y);
            EP = new DPoint(p2.X, p2.Y);
        }
    }

}


