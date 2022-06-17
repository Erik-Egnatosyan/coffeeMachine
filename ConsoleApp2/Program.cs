using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte maccoffee = 100;
            byte cappuccino = 150;
            byte espresso = 200;
            byte darkCoffee = 250;

            Console.WriteLine("Pls insert the coin and choise the coffee: ");
            Console.WriteLine($"Maccoffee costs {maccoffee}\nCappuccino costs {cappuccino}\nEspresso costs {espresso}\nDarkcoffee costs {darkCoffee}");
            byte money = byte.Parse(Console.ReadLine());
            Console.WriteLine("Pls choise the coffee: ");
            Console.WriteLine($"Write 1 if you want maccoffee.");
            Console.WriteLine($"Write 2 if you want cappuccino.");
            Console.WriteLine($"Write 3 if you want expresso.");
            Console.WriteLine($"Write 4 if you want darkcoffee.");
            byte number = byte.Parse(Console.ReadLine());

            if (number == 1)
            {
                while (money < maccoffee)
                {
                    Console.WriteLine($"Pls add more money {maccoffee - money}");
                    byte moreMoney = byte.Parse(Console.ReadLine());
                    money += moreMoney;
                }
                while (money > maccoffee)
                {
                    Console.WriteLine($"You entered too much money, take your change {money - maccoffee}");
                    break;
                }
                Console.WriteLine("Take your coffee");
            }
            else if (number == 2)
            {
                while (money < cappuccino)
                {
                    Console.WriteLine($"Pls add more money {cappuccino - money}");
                    byte moreMoney = byte.Parse(Console.ReadLine());
                    money += moreMoney;
                }
                while (money > cappuccino)
                {
                    Console.WriteLine($"You entered too much money, take your change {money - cappuccino}");
                    break;
                }
                Console.WriteLine("Take your coffee");
            }
            else if (number == 3)
            {
                while (money < espresso)
                {
                    Console.WriteLine($"Pls add more money {espresso - money}");
                    byte moreMoney = byte.Parse(Console.ReadLine());
                    money += moreMoney;
                }
                while (money > espresso)
                {
                    Console.WriteLine($"You entered too much money, take your change {money - espresso}");
                    break;
                }
                Console.WriteLine("Take your coffee");
            }
            else if (number == 4)
            {
                while (money < darkCoffee)
                {
                    Console.WriteLine($"Pls add more money {darkCoffee - money}");
                    byte moreMoney = byte.Parse(Console.ReadLine());
                    money += moreMoney;
                }
                while (money > darkCoffee)
                {
                    Console.WriteLine($"You entered too much money, take your change {money - darkCoffee}");
                    break;
                }
                Console.WriteLine("Take your coffee");
            }
            else
            {
                Console.WriteLine("Sorry your money or your choose not correct");
            }
        }
    }
}
