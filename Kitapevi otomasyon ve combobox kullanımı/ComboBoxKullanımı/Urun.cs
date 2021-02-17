using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBoxKullanımı
{
   public class Urun
    {
        public int id { get; set; }
        public string resim { get; set; }
        public string urunadi { get; set; }
        public string urunkategori { get; set; }
        public int stokadet { get; set; }
        public string yazar { get; set; }
        public string aciklama { get; set; }

        public override string ToString()
        {
            return urunadi; // comboboxta ürünün adını yazmak için tostringi override yaptım;
        }

    }
}
