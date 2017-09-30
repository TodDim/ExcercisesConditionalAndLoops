using System;


namespace RectangleArea
{
    class RectangleArea
    {
        static void Main()
        {
            Console.Write("a=");
            
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("RectangleArea's area is: {0}" , a*b);
            Console.WriteLine();
        }
    }
}
