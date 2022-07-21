using System;

namespace Abstractt
{
        abstract class Tugla
        {
            public int PaletKapasitesi { get; set; }
            public string DeltaSirketi { get; set; }
            //Tuglaların ortak Özellikleri’leri

            public abstract void TuglaFiyatı();
            //override edilecek abstract methodumuz
        }
        //Hitok Tuglası Sınıfı
        class HitokTuglası : Tugla //Ucak Abstract Class’ından kalıtılan Class
        {
            //Tugla Abstract Class’ından, Class kalıtırken override ettiğimiz, gövdesini doldurduğumuz method.
            public override void TuglaFiyatı() 
            {
                Console.WriteLine("Hitok Tuglasının Tane Fiyatı 20");
                Console.ReadLine();
            }

        }
        //Baca Tuglası Sınıfı
        class BacaTuglası : Tugla
        {
            public override void TuglaFiyatı()
            {
                Console.WriteLine("Baca Tuglası Fiyatı Tane Fiyatı 23");
                Console.ReadLine();

            }
        }
    class Program
    {
        static void Main(string[] args)
        {
            HitokTuglası H = new HitokTuglası();
            H.TuglaFiyatı();
        }
    }
}
