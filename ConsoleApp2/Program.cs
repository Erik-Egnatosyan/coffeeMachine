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
            byte expresso = 200;
            byte darkCoffee = 250;

            Console.WriteLine("Pls insert the coin. Mac:100, Capp:150, Expr:200, Dark: 250;");
            byte money = byte.Parse(Console.ReadLine());

            Console.WriteLine("Pls choose the drink");
            Console.WriteLine($"Write 1 if you want maccoffee. Price - {maccoffee}");
            Console.WriteLine($"Write 2 if you want cappuccino. Price - {cappuccino}");
            Console.WriteLine($"Write 3 if you want expresso. Price - {expresso}");
            Console.WriteLine($"Write 4 if you want darkCoffee. Price - {darkCoffee}");
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
                while (money < expresso)
                {
                    Console.WriteLine($"Pls add more money {expresso - money}");
                    byte moreMoney = byte.Parse(Console.ReadLine());
                    money += moreMoney;
                }
                while (money > expresso)
                {
                    Console.WriteLine($"You entered too much money, take your change {money - expresso}");
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
