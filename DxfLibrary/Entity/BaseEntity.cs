using DxfLibrary.Tables;

using System;
namespace DxfLibrary.Entity
{
    public abstract class BaseEntity
    {
        public Layer Layer { get; set; } // Katman

        public DxfColor Color { get; set; } // Renk
        public LineType LineType { get; set; } // Çizgi tipi
        public double LineWeight { get; set; } // Çizgi kalınlığı
    }

}



