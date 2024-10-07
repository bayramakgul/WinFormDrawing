using System;
namespace DxfLibrary.Entity
{
    public class Ellipse : BaseEntity
    {
        public DPoint Center { get; set; }
        public double MajorAxis { get; set; } // Ana eksen uzunluğu
        public double MinorAxis { get; set; } // Yardımcı eksen uzunluğu
    }

}

