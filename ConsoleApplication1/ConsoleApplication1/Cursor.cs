using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DaveMatthewsTextAdventure
{
    class Cursor
    {
        public static void WaitForKey()
        {
           System.ConsoleKeyInfo keyPress = System.Console.ReadKey();
        }
        public static int MakeChoice(int numChoices)
        {
            //NOTE: THE CHOICES HAVE TO HAVE A FREE LINE ABOVE AND BELOW THEM IN ORDER TO WORK PROPERLY.
            //ALSO, YOU NEED TO HAVE AT LEAST ONE FREE SPACE BEFORE EACH OF THE CHOICES OR ELSE
            //THE FIRST CHARACTER WILL BE LOST. YES, THIS IS BAD PROGRAMMING, BUT IT'S NOT HIGH ON THE
            //LIST OF PRIORITIES TO FIX, CONSIDERING THAT I'M THE ONLY ONE WRITING THIS.
            Console.SetCursorPosition(0, Console.CursorTop - (numChoices + 1));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\r>");
            Console.CursorVisible = false;
            int position = 0;
            ConsoleKeyInfo key = new ConsoleKeyInfo();

            do
            {
                while (Console.KeyAvailable == false)
                    Thread.Sleep(50); // Loop until input is entered.

                key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.UpArrow && position > 0)
                {
                    Console.Write("\r ");
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    //SFX.Play("Selection");
                    position--;
                    Console.Write("\r>");
                }
                else if (key.Key == ConsoleKey.DownArrow && position < (numChoices - 1))
                {
                    Console.Write("\r ");
                    Console.SetCursorPosition(0, Console.CursorTop + 1);
                  //  SFX.Play("Selection");
                    position++;
                    Console.Write("\r>");
                }
            } while (key.Key != ConsoleKey.Enter);
            Console.CursorVisible = true;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Clear();
            return position + 1;
            //Console.WriteLine("\rNRNRNRNRNRNRNRNRNRNRNRNRNRNRNRNRNR");
        }
    }
}
