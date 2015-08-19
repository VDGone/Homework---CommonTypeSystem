namespace _05._64BitArray
{
    using System;

    class Test
    {
        static void Main()
        {
            BitArray64 bits = new BitArray64(123456789012);
            BitArray64 bitsTwo = new BitArray64(012345678912);
            BitArray64 anotherBits = new BitArray64(123456789012);

            Console.WriteLine(bits);
            Console.WriteLine(bitsTwo);
            Console.WriteLine(anotherBits);
            Console.WriteLine("Are equals: {0}", bits == anotherBits);
            Console.WriteLine("Change bits: ");
            Console.WriteLine("before: {0}", bits);

            bits[43] = 1;
            bits[44] = 1;
            bits[45] = 1;
            bits[46] = 1;
            bits[47] = 1;
            bits[48] = 1;

            Console.WriteLine("after: {0}",bits);

            Console.WriteLine("Are different: {0}", bits != bitsTwo);
            Console.WriteLine("Are equals: {0}", bits.Equals(bitsTwo));
            Console.WriteLine("Are equals: {0}", bits == bitsTwo);
            Console.WriteLine("Are equals: {0}", bits == anotherBits);
        }
    }
}
