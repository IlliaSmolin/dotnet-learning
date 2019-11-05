using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string eKey, dKey;
            int encrypt, decrypt;

            Console.Write("Write integer number: ");
            decrypt = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write encryption key: ");
            eKey = Console.ReadLine();
            encrypt = Convert.ToInt32(decrypt) ^ Convert.ToInt32(eKey);
            Console.WriteLine($"Encrypted {decrypt} is = {encrypt}");
            Console.Write("Write decryption key: ");
            dKey = Console.ReadLine();
            decrypt = Convert.ToInt32(encrypt) ^ Convert.ToInt32(dKey);
            Console.WriteLine($"Decrypted {encrypt} is = {decrypt}");
        }
    }
}
