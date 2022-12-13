using System.Security.Cryptography;

namespace AbstractDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************");

            Memeli kedi = new Kedi();
            kedi.Yuru();
            Console.WriteLine("***********************************");

            Memeli kopek = new Kopek();
            kopek.Yuru();
            Console.WriteLine("***********************************");
            Memeli insan = new Insan();
            insan.Yuru();
            Console.WriteLine("***********************************");

        }
    }
    abstract class Memeli
    {
        public string Adi { get; set; }
        public virtual void Yuru()
        {

        }

    }
    class Insan : Memeli
    {
        public override void Yuru()
        {
            Console.WriteLine("*       İnsan 2 ayakla yürür      *");
        }
    }

    class Kopek : Memeli
    {
        public override void Yuru()
        {
            Console.WriteLine("*       Köpek 4 ayakla yürür      *");
        }
    }
    class Kedi : Memeli
    {
        public override void Yuru()
        {
            Console.WriteLine("*       Kedi 4 ayakla yürür       *");
        }
    }




}