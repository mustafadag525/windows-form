using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoxUygulama
{
   public class sanaldatabase
    {
        public static  List<Musteri> musteriler { get; set; }

        static sanaldatabase()
        {
            musteriler = new List<Musteri>();

        }



    }
}
