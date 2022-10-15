using System;
namespace ALevelTheory
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Console.WriteLine(CaeserCipher.Encipher("Catherine Wheel", 22));
            //Console.WriteLine(CaeserCipher.Decipher("Ywpdaneja Sdaah", 22));
            VernamCipher.Vernam();
        }
    }
}

