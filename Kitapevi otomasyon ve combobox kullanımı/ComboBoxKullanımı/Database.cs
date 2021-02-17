using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBoxKullanımı
{
   public class Database
    {
        public static List<Urun> uruntablo = new List<Urun>()
        {
            new Urun(){id=1,urunadi="bir ömür nasıl yaşanır",stokadet=10, urunkategori="roman", aciklama=@"Her şeyden evvel insanların birbirlerini çok sevmesi lazım. Sevginin olmadığı yerde hiçbir şey kurulamıyor.",yazar="İlber Ortaylı",resim=@"C:\Users\Lenovo PC\AppData\Roaming\Microsoft\Windows\Network Shortcuts\bir ömür.jfif"},

            
            new Urun(){ id=2, urunadi="heyet", stokadet=10,urunkategori="tarih", aciklama=@"16 Türk Devletini, yine 16 Türk Devletinin yıkması tesadüf müydü?
           
            Aslında yıkılan bir devlet yoktu, sadece ismi değiştiren bir HEYET vardı.
            Meta Han ‘dan bugüne kadar size anlatılmayan tarih, bu kitabın sayfaları arasında gizli.
            Ve inanın sayfaları çevirdikçe şaşıracaksınız, bildiklerinizin sadece basit birer bilgi olduğunu göreceksiniz.
            Gerçekleri öğrenmek için sadece ilk sayfayı okumanız yeterli.
            İnanın bu kitabı elinizden bırakamayacaksınız!" ,yazar="Halil Yaşar Kollu "  ,resim=@"C:\Users\Lenovo PC\AppData\Roaming\Microsoft\Windows\Network Shortcuts\heyet.jfif"},
            

            new Urun(){id=3, urunadi="suç ve ceza", stokadet=10,urunkategori="roman", aciklama=@"Suç ve Ceza; Rodion Romanoviç Raskolnikov adındaki bir gencin işlediği çifte cinayet üzerine yaşadıklarını konu alıyor. Raskolnikov, bir yandan hukuk öğrenimi görürken diğer yandan yoksullukla boğuşan bir genç. Para ihtiyacını ise tefeci bir kadına eşyalarını bırakarak karşılıyor. Yoksulluğuna çare bulamadığı gibi tefeciden yakasını da kurtaramayan Raskolnikov, bu kadının toplumun iyiliği için ölmesi gerektiğini düşünmeye başlıyor.

            Bir gün Raskolnikov, kendi maddi problemlerinin yanı sıra ailesinden de kötü bir haber alıyor.
            Kız kardeşinin kendisinden yaşça çok büyük biriyle evleneceğini duyması, ona yeni bir darbe indiriyor.
            Bunun üzerine Raskolnikov, tefeciyi öldürmeyi aklına koyarak kendini evden dışarı atıyor.
            Tefeci kadını öldürüp mücevherleri alıyor ancak işlediği
            cinayete kimsenin tanıklık etmemesi için onun kız kardeşini de öldürmek zorunda kalıyor.

            Raskolnikov’un ruh hali, bu çifte cinayetle birlikte yerle bir oluyor.
            İşlediği suçu kimse görmemiş olmasına rağmen korkusu ve vicdanı onu 
            büyük bir mahkumiyete sürüklüyor. Bir yandan mağdur, diğer yandan katil… 
            Raskolnikov’u cinayete iten sebepler, onun alt üst olan iç dünyası ve sonrası
            ile siz de onun yeniden doğuşuna şahit olacaksınız. Bu kitabı okurken, 
            kalp atışınızın arttığını duyumsayacaksınız.  " ,yazar=" Fyodor Mihayloviç Dostoyevski" 
                ,resim=@"C:\Users\Lenovo PC\AppData\Roaming\Microsoft\Windows\Network Shortcuts\suc ve ceza.jpg"},
            





        };
    }
}
