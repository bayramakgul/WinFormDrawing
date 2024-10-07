using System;
namespace DxfLibrary.Entity
{
    using System.Collections.Generic;

    public class Block
    {
        public string Name { get; set; } // Blok adı

        public List<BaseEntity> Entities { get; set; } // Blok içindeki entity'ler

        public Block()
        {
            Entities = new List<BaseEntity>(); // Entity listesini başlat
        }
    }

}

