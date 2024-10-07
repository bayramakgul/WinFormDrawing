namespace DxfLibrary.Entity
{

    public class Polyline : BaseEntity
    {
        public List<DPoint> Vertices { get; set; } // noktalar

        public Polyline()
        {
            Vertices = new List<DPoint>();
        }
    }

}

