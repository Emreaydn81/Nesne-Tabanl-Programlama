using System;

namespace Abstract1
{
  
    abstract class Kereste
    {
        public string renk;
        public string uzunluk;
        abstract public void ozellikyaz();
    }

    class Beşon : Kereste
    {
        public string Agaç;
        public override void ozellikyaz()
        {
            Console.WriteLine("Beşonun  Özellikleri");
            Console.WriteLine("Renk: {0}", renk);
            Console.WriteLine("uzunluk: {0}", uzunluk);
            Console.WriteLine("Agaç: {0}", Agaç);
        }
    }

    class Plamut : Kereste
    {
        public string Agaç;
        public override void ozellikyaz()
        {
            Console.WriteLine("Plamut'un Özellikleri");
            Console.WriteLine("Renk: {0}", renk);
            Console.WriteLine("uzunluk: {0}", uzunluk);
            Console.WriteLine("Agaç: {0}", Agaç);
        }
    }
    class Tugla : Kereste
    {
        public string Toprak;
        public override void ozellikyaz()
        {
            Console.WriteLine("OnaOn'un Özellikleri");
            Console.WriteLine("Renk: {0}", renk);
            Console.WriteLine("uzunluk: {0}", uzunluk);
            Console.WriteLine("Toprak: {0}", Toprak);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Beşon b = new Beşon();
            Plamut p = new Plamut();
            Tugla t = new Tugla();
            b.renk = "Beyaz";
            b.uzunluk = "3m";
            b.Agaç = "Kavak";
            p.renk = "Koyu Kahverengi";
            p.uzunluk = "2.5m";
            p.Agaç = "Meşe";
            t.renk = "Kırmızı";
            t.uzunluk = "19cm";
            t.Toprak = "Kil Bazlı";
            b.ozellikyaz();
            t.ozellikyaz();
            p.ozellikyaz();
            Console.ReadKey();
        }
    }

}
