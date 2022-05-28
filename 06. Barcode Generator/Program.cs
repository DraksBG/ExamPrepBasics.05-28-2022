using System;

namespace _06._Barcode_Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            for (int b1 = num1 / 1000; b1 <= num2 / 1000; b1++)
            {
                if (b1 % 2 == 0)
                {
                    continue;
                }

                for (int b2 = num1 / 100 % 10; b2 <=  num2 / 100 % 10; b2++)
                {
                    if (b2 % 2 == 0)
                    {
                        continue;
                    }

                    for (int b3 = num1 / 10 % 10; b3 <= num2 / 10 % 10; b3++)
                    {
                        if (b3 % 2 == 0)
                        {
                            continue;
                        }

                        for (int b4 = num1 % 10; b4 <= num2 % 10; b4++)
                        {
                            if (b4 % 2 == 0)
                            {
                                continue;
                            }

                            Console.Write($"{b1}{b2}{b3}{b4} ");
                        }
                    }
                }
            }
        }
    }
}
