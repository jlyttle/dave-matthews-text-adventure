using System;
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

            Text("The Legend of Fate/big mac: Unlimited Dank Works in the House", false);
            Text("Directed by Yung Chang", false);
            Text("Music provided by Scott Oelkers and Hatsune Miku", false);
            Text("Yeast-based nourishment provided by Daichi Shijima", true);
            int decisionValue = MakeDecision("Do you like big macs?", "Yes, big macs are love, big macs are life", "No, they have too much cholesterol", 0);
            if (decisionValue == 1)
            {
                System.Console.WriteLine("You are worthy");
                System.Console.WriteLine("[Press the damn key, Shinji]");
                System.ConsoleKeyInfo keyPress = System.Console.ReadKey();
            }
            if (decisionValue == 2)
            {
                System.Console.WriteLine("Get out of here you filthy McDonald's casual");
                System.Console.WriteLine("[Press the damn key, Shinji]");
                System.ConsoleKeyInfo keyPress = System.Console.ReadKey();
            }
        }

        public static void Text(string text, Boolean press)
        {
            //True leads to a required key press
            System.Console.WriteLine(text);
            if (press == true)
            {
                System.Console.WriteLine("[Press the damn key, Shinji]");
                System.ConsoleKeyInfo keyPress = System.Console.ReadKey();
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
