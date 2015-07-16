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
        }
        
        static void Text(string text, Boolean press)
        {
            System.Console.WriteLine(text);
            if (press == true)
            {
                System.Console.WriteLine("[Press the damn key, Shinji]");
                System.ConsoleKeyInfo keyPress = System.Console.ReadKey();
            }
        }
        static void Decisions(string decisionText, Boolean press)
        {


        }
    }
}
