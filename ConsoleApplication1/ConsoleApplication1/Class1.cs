using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class DecisionZero
    {
       public static void accept()
        {
            System.Console.WriteLine("You are worthy");
            System.Console.WriteLine("[Press the damn key, Shinji]");
            System.ConsoleKeyInfo keyPress = System.Console.ReadKey();
        }
       public static void reject()
        {
            System.Console.WriteLine("Get out of here you filthy McDonald's casual");
            System.Console.WriteLine("[Press the damn key, Shinji]");
            System.ConsoleKeyInfo keyPress = System.Console.ReadKey();
        }
    }
}
