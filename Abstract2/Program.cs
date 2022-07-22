using System;

namespace Abstract2
{
    abstract class SoyutSinif
    {
        public void Metot1()
        {
            Console.WriteLine("Metot 1");

        }
        public abstract void Metot2();
        public int sayı1 { get; set;  }
        public abstract int sayı2 { get; set; }
    }
    class A : SoyutSinif
    {
        public override void Metot2()
        {
            Console.WriteLine("Sınıf a içerisindeki Metot 2");
        }
        public override int sayı2 { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A nesne1 = new A();

            nesne1.Metot1();
            nesne1.Metot2();
            nesne1.sayı1 = 10;
            nesne1.sayı2 = 25;
            Console.WriteLine("sayı1 degeri :  " + nesne1.sayı1);
            Console.WriteLine("sayı2 degeri :  " + nesne1.sayı2);
            Console.ReadKey();
        }
    }
}

