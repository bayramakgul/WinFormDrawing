using System;
namespace DxfLibrary.Entity
{
    public class Circle : BaseEntity
    {
        public DPoint Center { get; set; } // Merkez koordinatı

        public double Radius { get; set; } // Yarıçap
    }

}

