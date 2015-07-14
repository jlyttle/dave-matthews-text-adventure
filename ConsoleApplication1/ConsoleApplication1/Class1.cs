using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Text
    {
        Text(string text)
        {
            System.Console.WriteLine(text);
            System.Console.WriteLine("[Press the damn key, Shinji]");
            System.ConsoleKeyInfo keyPress = System.Console.ReadKey();
            
        }
    }
}
