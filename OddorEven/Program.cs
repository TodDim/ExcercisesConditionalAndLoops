using System;


namespace OddorEven
{
    class OddorEven
    {
        static void Main()
        {
            int number = Int32.Parse(Console.ReadLine());
      if (number % 2 ==0) 
          Console.WriteLine("Number is even ");
      else Console.WriteLine("Number is odd");
        }
    }
}
