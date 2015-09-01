﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Text("The Legend of Fate/big mac: Unlimited Dank Works in the House", false, false);
            Text("Directed by Yung Chang", false, false);
            Text("Music provided by Scott Oelkers and Hatsune Miku", false, false);
            Text("Yeast-based nourishment provided by Daichi Shijima", true, true);
            int decisionValue = MakeDecision("Do you like big macs?", "Yes, big macs are love, big macs are life", "No, they have too much cholesterol", 0);
            if (decisionValue == 1)
            {
                Text("You are worthy", true, true);
            }
            if (decisionValue == 2)
            {
                Text("Get out of here you filthy McDonald's casual", true, true);
            }
            Text("In this game you play Dave Matthews, a jack-of-all-trades man with a passion for McDonalds, Ballpits, Skeeball, and butchering cows.However, you do none of this in this game as you play a frail man realizing he is nothing more than what the machine he lives in says he is. You will meet fantastical creatures and pick up bad habits along the way that will change your life forever.", true, true);
            Text("Dave awoke from his nightmare with a startle.",true, true);
            Text("As the memory of his dream began fading away, he sat up, reflecting upon how famished he was.", false, false);
            Text("The seductive scent of a big mac from McDonalds crosssed his mind, but first he decided to turn on his TV for a little morning entertainment.", true, true);
            Text("As a very busy man with a full schedule ahead of him, Dave had no time for games. He realized long ago that one must seize the day.", false, false);
            Text("He specifically learned this during an incident in 2004 whereupon his tour bus driver convinced him to dump 500 pounds of crap onto a passing ferry in Chicago.", true, true);
            Text("In any case, Dave turned on his mid-90's TV set that he hadn't replaced since the last time he got a paycheck and immediately saw an incredibly anime face greeting him with an informative ad for a new dating website.", true, true);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Text("This new startup is the cloud solution you've been waiting for. We have on-site backups of all your friends' deaths and our 4K MP4's are auto-tagged with location information and current light levels. For a small retrieval fee, we also sync with Dropbox. Now accepting Bitcoin.", false, false);
            Console.ResetColor();
            Text("", true, true);
            Text("Dave:", false, false);
            Text("     \"I don't give a crap!\"", true, true);
        }

        public static void Text(string text, Boolean press, Boolean clear)
        {
            //True leads to a required key press
            System.Console.WriteLine(text);
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
    }
}
