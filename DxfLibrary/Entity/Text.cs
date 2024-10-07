using DxfLibrary.Tables;
namespace DxfLibrary.Entity
{
    public class Text : BaseEntity
    {
        public TextStyle Style { get; set; }

        public string Content { get; set; } // Metin içeriği

        public DPoint Position { get; set; } // koordinatı

        public double Height { get; set; } // Metin yüksekliği
    }

}

