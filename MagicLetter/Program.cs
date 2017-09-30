using System;


namespace MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char thirdLetter = char.Parse(Console.ReadLine());

            for (char i = firstLetter; i <= secondLetter; i++)
            {
                for (int j = firstLetter; j <= secondLetter; j++)
                {
                    for (int k = firstLetter; k <= secondLetter; k++)
                    {
                        if((k == thirdLetter)||(j == thirdLetter)||(i == thirdLetter))
                        {
                            continue;
                        }
                        Console.Write("{0}{1}{2}", (char)i, (char)j, (char)k);
                        Console.Write(" ");
                    }
                }
            }
        }
    }
}