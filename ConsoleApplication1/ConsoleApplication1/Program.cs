using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DaveMatthewsTextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Item.LoadItemsIntoDictinoary();
            Location.LoadLocationsIntoDictinoary();
            PrintTitleScreenText();

            int decisionValue = MakeDecision("Do you like big macs?", "Yes, big macs are love, big macs are life", "No, they have too much cholesterol", 0);
            if (decisionValue == 1)
            {
                Text("You are worthy", true, true);
            }
            if (decisionValue == 2)
            {
                Text("Get out of here you filthy McDonald's casual", true, true);
            }
            Storyline.intro(); 
            Menu.MenuBuilder();
        }

        public enum textSpeed { SLOW, MEDIUM, FAST, IMMEDIATE };
        public static void Text(string text, Boolean press, Boolean clear = false, textSpeed speed = textSpeed.MEDIUM)
        {
            //True leads to a required key press
            if (speed == textSpeed.IMMEDIATE)
            {
                Console.WriteLine(text);
            }
            else if (speed == textSpeed.FAST)
            {
                foreach (char c in text)
                {
                    System.Console.Write(c);
                    Thread.Sleep(10);
                }
            }
            else if (speed == textSpeed.MEDIUM)
            {
                foreach (char c in text)
                {
                    System.Console.Write(c);
                    Thread.Sleep(20);
                }
            }
            else if (speed == textSpeed.SLOW)
            {
                foreach (char c in text)
                {
                    Console.Write(c);
                    Thread.Sleep(30);
                }
            }

           if (press == true)
                {
                System.Console.WriteLine("[Press the damn key, Shinji]");
                System.ConsoleKeyInfo keyPress = System.Console.ReadKey();
                if (clear == true)
                {
                    System.Console.Clear();
                }
            }
        }

        static int MakeDecision(string text, string decisionOne, string decisionTwo, int decisionNumber)
        {
            ConsoleKeyInfo decision;
            System.Console.WriteLine(text);
            System.Console.WriteLine("[Choose your meal size, Dave]");
            System.Console.WriteLine("1. Happy Meal:  " + decisionOne);
            System.Console.WriteLine("2. Super Size:  " + decisionTwo);
           
            while(true)
            {
                decision = System.Console.ReadKey();
                System.Console.Write("\r");
                if (decision.Key == ConsoleKey.D1)
                {
                    return 1;
                }
                if (decision.Key == ConsoleKey.D2)
                {
                    return 2;
                }
                System.Console.WriteLine("Don't be a Daichster, press 1 or 2.");
            }
        }
        static int MakeDecision(string text, string decisionOne, string decisionTwo, string decisionThree, int decisionNumber)
        {
            ConsoleKeyInfo decision;
            System.Console.WriteLine(text);
            System.Console.WriteLine("[Choose your meal size, Dave]");
            System.Console.WriteLine("1.  Kid's Size:  " + decisionOne);
            System.Console.WriteLine("2. Super Size:  " + decisionTwo);
            while (true)
            {
                decision = System.Console.ReadKey();
                System.Console.Write("\r");
                if (decision.Key == ConsoleKey.D1)
                {
                    return 1;
                }
                if (decision.Key == ConsoleKey.D2)
                {
                    return 2;
                }
                if (decision.Key == ConsoleKey.D3)
                {
                    return 3;
                }
                System.Console.WriteLine("Don't be a Daichster, press 1, 2 or 3.");
            }
        }

        private static void PrintTitleScreenText()
        {
            //THIS IS A SUPER SHITTY WAY TO DO THIS.
            //What you'd want to do is overload the Text function to take an integer value that defines how long you should wait before posting the next thing.
            Text(" __   __  __    _  ___      ___   __   __  ___   _______  _______  ______  ", false, false, textSpeed.IMMEDIATE);
            Thread.Sleep(100);
            Text("|  | |  ||  |  | ||   |    |   | |  |_|  ||   | |       ||       ||      | ", false, false, textSpeed.IMMEDIATE);
            Thread.Sleep(100);
            Text("|  | |  ||   |_| ||   |    |   | |       ||   | |_     _||    ___||  _    |", false, false, textSpeed.IMMEDIATE);
            Thread.Sleep(100);
            Text("|  |_|  ||       ||   |    |   | |       ||   |   |   |  |   |___ | | |   |", false, false, textSpeed.IMMEDIATE);
            Thread.Sleep(100);
            Text("|       ||  _    ||   |___ |   | |       ||   |   |   |  |    ___|| |_|   |", false, false, textSpeed.IMMEDIATE);
            Thread.Sleep(100);
            Text("|       || | |   ||       ||   | | ||_|| ||   |   |   |  |   |___ |       |", false, false, textSpeed.IMMEDIATE);
            Thread.Sleep(100);
            Text("|_______||_|  |__||_______||___| |_|   |_||___|   |___|  |_______||______| ", false, false, textSpeed.IMMEDIATE);
            Thread.Sleep(100);
            Text(" ______   _______  __    _  ___   _ ", false, false, textSpeed.IMMEDIATE);
            Thread.Sleep(100);
            Text("|      | |   _   ||  |  | ||   | | |", false, false, textSpeed.IMMEDIATE);
            Thread.Sleep(100);
            Text("|  _    ||  |_|  ||   |_| ||   |_| |", false, false, textSpeed.IMMEDIATE);
            Thread.Sleep(100);
            Text("| | |   ||       ||       ||      _|", false, false, textSpeed.IMMEDIATE);
            Thread.Sleep(100);
            Text("| |_|   ||       ||  _    ||     |_ ", false, false, textSpeed.IMMEDIATE);
            Thread.Sleep(100);
            Text("|       ||   _   || | |   ||    _  |", false, false, textSpeed.IMMEDIATE);
            Thread.Sleep(100);
            Text("|______| |__| |__||_|  |__||___| |_|", false, false, textSpeed.IMMEDIATE);
            Thread.Sleep(100);
            Text(" _     _  _______  ______    ___   _  _______ ", false, false, textSpeed.IMMEDIATE);
            Thread.Sleep(100);
            Text("| | _ | ||       ||    _ |  |   | | ||       |", false, false, textSpeed.IMMEDIATE);
            Thread.Sleep(100);
            Text("| || || ||   _   ||   | ||  |   |_| ||  _____|", false, false, textSpeed.IMMEDIATE);
            Thread.Sleep(100);
            Text("|       ||  | |  ||   |_||_ |      _|| |_____ ", false, false, textSpeed.IMMEDIATE);
            Thread.Sleep(100);
            Text("|       ||  |_|  ||    __  ||     |_ |_____  |", false, false, textSpeed.IMMEDIATE);
            Thread.Sleep(100);
            Text("|   _   ||       ||   |  | ||    _  | _____| |", false, false, textSpeed.IMMEDIATE);
            Thread.Sleep(100);
            Text("|__| |__||_______||___|  |_||___| |_||_______|", false, false, textSpeed.IMMEDIATE);
            Thread.Sleep(100);
            Text("\n", false, false, textSpeed.IMMEDIATE);
            Thread.Sleep(500);
            Text("The Legend of Fate/big mac: Unlimited Dank Works in the House", false);
            Text("Directed by Yung Chang", false);
            Text("Music provided by Scott Oelkers and Hatsune Miku", false);
            Text("Yeast-based nourishment provided by Daichi Shijima", true);
        }
    }
}
