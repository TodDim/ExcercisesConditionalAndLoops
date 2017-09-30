using System;
namespace NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDamage = Int32.Parse(Console.ReadLine());
            int goshoDamage = Int32.Parse(Console.ReadLine());
            int healthPesho = 100;
            int healthGosho = 100;
            int runs = 0;
            while (healthPesho > 0 && healthGosho > 0)
            {
                runs++;
                if (runs % 2 != 0)
                {
                    healthGosho -= peshoDamage;
                    if (healthGosho <= 0)
                    {
                        Console.WriteLine("Pesho won in {0}th round.", runs);
                        break;
                    }            
                    else
                    {
                        Console.WriteLine("Pesho used Roundhouse kick and reduced Gosho to {0} health.", healthGosho);
                    }
                }
                else
                {
                    healthPesho -= goshoDamage;
                    if (healthPesho <= 0) 
                    {
                        Console.WriteLine("Gosho won in {0}th round.", runs);
                        break;
                    }             
                    else
                    {
                        Console.WriteLine("Gosho used Thunderous fist and reduced Pesho to {0} health.", healthPesho);
                    }
                }
                if (runs % 3 == 0)
                {
                    healthPesho += 10;
                    healthGosho += 10;
                }
            }
        }
    }
}

