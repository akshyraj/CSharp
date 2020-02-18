using System;

namespace Practical_3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the decimal value: ");
            int decValue = Int32.Parse(Console.ReadLine());
            decimalToBinary(decValue);
            Console.Write("Enter the decimal value: ");
            int decValue2 = Int32.Parse(Console.ReadLine());
            decimalToOctal(decValue2);
            Console.Write("Enter the binary value: ");
            int binaryNo = Int32.Parse(Console.ReadLine());
            binaryToDecimal(binaryNo);
        }
        static void decimalToBinary(int decimalNo)
        {
            int[] binary = new int[50];
            int i = 0;
            while (decimalNo != 0)
            {
                binary[i] = (decimalNo % 2);
                i++;
                decimalNo = (decimalNo / 2);
            }
            for (int j = i - 1; j >= 0; j--)
            {
                Console.Write(binary[j]);
            }
        }
        static void decimalToOctal(int decimalNo)
        {
            int[] binary = new int[50];
            int i = 0;
            while (decimalNo != 0)
            {
                binary[i] = (decimalNo % 8);
                i++;
                decimalNo = (decimalNo / 8);
            }
            for (int j = i - 1; j >= 0; j--)
            {
                Console.Write(binary[j]);
            }
        }
        static void binaryToDecimal(int binaryNo)
        {
            int rem, decVal=0, baseVal=1;
            int binVal = binaryNo;
            while (binaryNo > 0)
            {
                rem = binaryNo % 10;
                decVal = decVal + rem * baseVal;
                binaryNo = binaryNo / 10;
                baseVal = baseVal * 2;
            }
            Console.Write(decVal);
        }
    }
}