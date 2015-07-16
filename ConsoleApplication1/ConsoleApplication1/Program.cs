using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static int[] decisionArray = new int[10];
        static void Main(string[] args)
        {

            Text("The Legend of Fate/big mac: Unlimited Dank Works in the House", false);
            Text("Directed by Yung Chang", false);
            Text("Music provided by Scott Oelkers and Hatsune Miku", false);
            Text("Yeast-based nourishment provided by Daichi Shijima", true);
            Decisions("Do you like big macs?", "Yes, big macs are love, big macs are life", "No, they have too much cholesterol", 0);
            if (decisionArray[0] == 1)
            {
                DecisionZero.accept();
            }
            if (decisionArray[0] == 2)
            {
                DecisionZero.reject();
            }
        }

        static void Text(string text, Boolean press)
        {
            //True leads to a required key press
            System.Console.WriteLine(text);
            if (press == true)
            {
                System.Console.WriteLine("[Press the damn key, Shinji]");
                System.ConsoleKeyInfo keyPress = System.Console.ReadKey();
            }
        }
        static void Decisions(string text, string decisionOne, string decisionTwo, int decisionNumber)
        {

            ConsoleKeyInfo decision;
            System.Console.WriteLine(text);
            System.Console.WriteLine("[Choose your meal size, Dave]");
            System.Console.WriteLine("1.  Kid's Size:  " + decisionOne);
            System.Console.WriteLine("2. Super Size:  " + decisionTwo);
            decision = System.Console.ReadKey();
            if (decision.Key == ConsoleKey.D1)
            {
                decisionArray[decisionNumber] = 1;
            }
            if (decision.Key == ConsoleKey.D2)
            {
                decisionArray[decisionNumber] = 2;
            }
        }
        static void Decisions(string text, string decisionOne, string decisionTwo, string decisionThree, int decisionNumber)
        {
            ConsoleKeyInfo decision;
            System.Console.WriteLine(text);
            System.Console.WriteLine("[Choose your meal size, Dave]");
            System.Console.WriteLine("1.  Kid's Size:  " + decisionOne);
            System.Console.WriteLine("2. Super Size:  " + decisionTwo);
            decision = System.Console.ReadKey();
            if (decision.Key == ConsoleKey.D1)
            {
                decisionArray[decisionNumber] = 1;
            }
            if (decision.Key == ConsoleKey.D2)
            {
                decisionArray[decisionNumber] = 2;
            }
            if (decision.Key == ConsoleKey.D3)
            {
                decisionArray[decisionNumber] = 3;
            }
        }
    }
}
