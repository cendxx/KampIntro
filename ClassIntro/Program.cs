namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.Egitmen = "ulaş özgür çendik";
            kurs1.IzlenmeOrani = 85;
            kurs1.ders = "java";

            Kurs kurs2 = new Kurs();
            kurs2.ders = "c#";

            // Console.WriteLine(kurs1.Egitmen + " " + kurs1.ders);
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.ders);
            }

            Urun urun1 = new Urun();

        }
    }
    class Kurs
    {
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
        public string ders { get; set; }

    }
    
}