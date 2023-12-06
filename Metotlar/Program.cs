namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();

            urun1.Id = "karpuz";
            urun1.Aciklama = "1.rafta";
            urun1.urunAdi = "kışlık meyve";

            Urun urun2 = new Urun();
            urun2.Id = "elma";
            urun2.Aciklama = "2. rafta";
            urun2.urunAdi = "yaz-kış meyvesi";

            Urun[] urunler = new Urun[] {urun1 , urun2 };

            foreach (Urun urunx in urunler )
            {
                Console.WriteLine(urunx.Id);
                Console.WriteLine(urunx.Aciklama);
                Console.WriteLine(urunx.urunAdi);
                Console.WriteLine(urunx.stokAdedi);
                Console.WriteLine("--------------");

                Console.WriteLine("-------------Metotlar--------");


            }
            SepetMenager sepetmenager = new SepetMenager();

            sepetmenager.Ekle(urun1);
            sepetmenager.Ekle(urun2);



        }
    }
}