using System;
using System.Linq;

namespace EccLibCSTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] data = MakeRandomData(20);
            byte[] encoded = new byte[20];
            EccLib.Functions.DummyEncode(data, encoded);
            byte[] decoded = new byte[20];
            EccLib.Functions.DummyDecode(encoded, decoded);
            Console.WriteLine(encoded.ToString());
            Console.WriteLine(encoded[0]);
            Console.WriteLine(encoded.SequenceEqual(decoded));
            Console.ReadLine();
        }

        static byte[] MakeRandomData(int size)
        {
            byte[] data = new byte[size];
            Random rng = new Random();
            rng.NextBytes(data);
            return data;
        }
    }
}
