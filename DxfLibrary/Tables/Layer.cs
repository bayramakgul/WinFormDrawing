using System.Drawing;

namespace DxfLibrary.Tables
{
    public class Layer
    {
        public string Name { get; set; }
        public int Level {  get; set; } // çizim sırası

        public Color Color { get; set; }
        public LineType LineType { get; set; }

        public float LineWeight { get; set; }

        public bool Visible { get; set; }
        public bool Locked { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
