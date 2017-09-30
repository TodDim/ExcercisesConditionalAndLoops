using System;


namespace GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            short n = short.Parse(Console.ReadLine());
            short m = short.Parse(Console.ReadLine());
            if (m >= n)
            {
                int magicNumber = Int32.Parse(Console.ReadLine());
                int count = 0;
                int first = 0;
                int second = 0;
                int countEqualsMagic = 0;
                int sum = 0;
                for (int i = n; i <= m; i++)
                {
                    for (int j = n; j <= m; j++)
                    {
                        count++;
                        sum += j + i;
                        if (sum == magicNumber)
                        {
                            first = i;
                            second = j;
                            countEqualsMagic++;
                        }
                    }
                    sum = 0;
                }
                if (countEqualsMagic != 0)
                {
                    Console.WriteLine("Number found! {0} + {1} = {2}", first, second, magicNumber);
                }
                else
                {
                    Console.WriteLine("{0} combinations - neither equals {1}", count, magicNumber);
                }
            }

        }

    }
}
