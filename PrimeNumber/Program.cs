using System;

//class Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime
class PrimeNumber
{
    static void Main()
        {
            int x = Int32.Parse(Console.ReadLine());
            if (x % 2 == 0 || x % 3 == 0 || x % 4 == 0 || x % 5 == 0 || x % 6 == 0 || x % 7 == 0 || x % 8 == 0 || x % 9 == 0)
            {
          
            Console.WriteLine("NOTPRIME");
            }
            else
            {
                Console.WriteLine("DA!!!");
            }
        }
}

