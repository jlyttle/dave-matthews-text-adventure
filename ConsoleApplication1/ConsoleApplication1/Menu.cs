using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DaveMatthewsTextAdventure
{
    class Menu
    {
        public static void MenuBuilder()
        {
            int maxItems = 3;
            System.Console.WriteLine("What will Dave do?");
            System.Console.WriteLine(" 1. Talk");
            System.Console.WriteLine(" 2. Items");
            System.Console.WriteLine(" 3. Locations");
            // if (fartUnlocked == true)
            //{
            //  maxItems = 3;
            //}
            Console.SetCursorPosition(0, Console.CursorTop - (maxItems));
            Console.Write("\r>");
            Console.CursorVisible = false;
            int position = 1;
            ConsoleKeyInfo key = new ConsoleKeyInfo();

            do
            {
                while (Console.KeyAvailable == false)
                    Thread.Sleep(50); // Loop until input is entered.

                key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.UpArrow && position > 1)
                {
                    Console.Write("\r ");
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    //SFX.Play("Selection");
                    position--;
                    Console.Write("\r>");
                }
                else if (key.Key == ConsoleKey.DownArrow && position < (maxItems))
                {
                    Console.Write("\r ");
                    Console.SetCursorPosition(0, Console.CursorTop + 1);
                    //SFX.Play("Selection");
                    position++;
                    Console.Write("\r>");
                }
            } while (key.Key != ConsoleKey.Enter);
            Console.CursorVisible = true;
            maxItems = position;
            Console.Clear();
            if (position == 1)
            {
                Console.WriteLine("Dave screamed out into the void.");
                System.Console.WriteLine("[Press the damn key, Shinji]");
                System.ConsoleKeyInfo keyPress = System.Console.ReadKey();
                MenuBuilder();
            }
            else if (position == 2)
            {
                Console.WriteLine("Money Wad");
                System.Console.WriteLine("[Press the damn key, Shinji]");
                System.ConsoleKeyInfo keyPress = System.Console.ReadKey();
                MenuBuilder();
            }
            else if (position == 3)
            {
                Console.WriteLine("Where would you like to go today?");
                Console.WriteLine(" McDonald's");
                Console.WriteLine(" Back");
                maxItems = 2;
                Console.SetCursorPosition(0, Console.CursorTop - (maxItems));
                Console.Write("\r>");
                Console.CursorVisible = false;
                position = 1;
                ConsoleKeyInfo key2 = new ConsoleKeyInfo();

                do
                {
                    while (Console.KeyAvailable == false)
                        Thread.Sleep(50); // Loop until input is entered.

                    key2 = Console.ReadKey(true);
                    if (key2.Key == ConsoleKey.UpArrow && position > 1)
                    {
                        Console.Write("\r ");
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        //SFX.Play("Selection");
                        position--;
                        Console.Write("\r>");
                    }
                    else if (key2.Key == ConsoleKey.DownArrow && position < (maxItems))
                    {
                        Console.Write("\r ");
                        Console.SetCursorPosition(0, Console.CursorTop + 1);
                        //SFX.Play("Selection");
                        position++;
                        Console.Write("\r>");
                    }
                } while (key2.Key != ConsoleKey.Enter);
                Console.CursorVisible = true;
                maxItems = position;
                Console.Clear();
                // this probably needs to be worked so we can use the menu in other areas
                if (position == 1)
                {
                    Console.WriteLine("Dave opened his front door and caught a big juicy whiff of fresh air. As he was about to make his trek to his new lambo that he couldn't fit in his garage due to his extensive knowledge collection, an increasingly closer figure began invading his personal space. As he approached, Dave thought he recognized him as a portly version of his flautist he recently fired, complete with red Dave Matthews Band cap from the 2008 Northern Thailand tour. However, at second glance, he couldn't tell. He got his pepper spray can at the ready.");
                    System.Console.WriteLine("[Press the damn key, Shinji]");
                    System.ConsoleKeyInfo keyPress = System.Console.ReadKey();
                }
                if (position == 2) ;
                {
                    MenuBuilder();
                }
            }
        }
    }
}
