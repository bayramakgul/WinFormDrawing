using System;
namespace DxfLibrary.Entity
{
    public class Arc : BaseEntity
    {
        public DPoint Center { get; set; } // Merkez koordinatı

        public double Radius { get; set; } // Yarıçap
        public double StartAngle { get; set; } // Başlangıç açısı
        public double EndAngle { get; set; } // Bitiş açısı
    }

}

