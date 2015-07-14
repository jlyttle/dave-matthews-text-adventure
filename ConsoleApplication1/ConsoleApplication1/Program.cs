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
            System.Console.WriteLine("The Legend of Fate/big mac: Unlimited Dank Works in the House");
            KeyPressRequired();
            System.Console.WriteLine("Directed by Yung Chang");
            KeyPressRequired();
            System.Console.WriteLine("Music provided by Scott Oelkers and Hatsune Miku");
            KeyPressRequired();
            Text("Yeast-based nourishment provided by Daichi Shijima");
        }
        static void KeyPressRequired()
        {
            //There has to be a way to make this come up on its own without having to put it after each line.  This is just begging for a mistake to happen.
            System.Console.WriteLine("[Press the damn key, Shinji]");
            System.ConsoleKeyInfo keyPress = System.Console.ReadKey();
        }
        static void Text(string x)
        {
            System.Console.WriteLine(x);
            System.Console.WriteLine("[Press the damn key, Shinji]");
            System.ConsoleKeyInfo keyPress = System.Console.ReadKey();
        }
    }
}
