using System;
using System.Text;

namespace ALevelTheory
{
    public class VernamCipher
    {
        public static void Vernam()
        {
            Console.WriteLine("Enter One time pad: ");
            string s = Console.ReadLine();
            byte[] OTP = Encoding.ASCII.GetBytes(s);

            Console.WriteLine("Enter code: ");
            string q = Console.ReadLine();
            byte[] input = Encoding.ASCII.GetBytes(q);

            byte[] output = new byte[4];

            byte carry = 0;

            for (int w = 0; w<4; w++)
            {
                carry = (byte)((Convert.ToInt32(OTP[w])) ^ (Convert.ToInt32(input[w])));
                output[w] = carry;
            }

            string mystring = System.Text.Encoding.ASCII.GetString(output);

            Console.WriteLine(mystring);

        }
    }
}

