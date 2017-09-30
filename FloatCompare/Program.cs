using System;
    class Program
    {
        static void Main()
        {
            float a = 5.3f;
            float b = 6.01f;
            double c = 5.00000001;
            double d = 5.00000003;
            Console.WriteLine(a>b);
            Console.WriteLine(c<d);
            Console.WriteLine("©");
            char symbol = 'd';
            Console.WriteLine("code of '{0}' is '{1}'", symbol  , (int) symbol  );
        }
    }

