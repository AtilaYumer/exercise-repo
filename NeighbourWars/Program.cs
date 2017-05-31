using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            var peshoDamage = int.Parse(Console.ReadLine());
            var goshoDamage = int.Parse(Console.ReadLine());

            var peshoHealth = 100;
            var goshoHealth = 100;
            var temp = 1;

            while (peshoHealth > 0 && goshoHealth > 0)
            {
                // Odd rounds Pesho attack Gosho

                if (temp % 2 != 0)
                {
                    if (goshoHealth > peshoDamage)
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth - peshoDamage} health.");
                    goshoHealth -= peshoDamage;
                    if (goshoHealth <= 0)
                        break;
                }
                if (temp % 2 == 0)  // Every single round Gosho attack Pesho
                {
                    if (peshoHealth > goshoDamage)
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth - goshoDamage} health.");
                    peshoHealth -= goshoDamage;
                    if (peshoHealth <= 0)
                        break;
                }
                if (temp % 3 == 0)     //Every third round Pesho and Gosho receives 10 health
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }
                temp++;
            }

            if (peshoHealth <= 0)
            {
                Console.WriteLine($"Gosho won in {temp}th round.");
            }
            else if (goshoHealth <= 0)
            {
                Console.WriteLine($"Pesho won in {temp}th round.");
            }
        }
    }
}
