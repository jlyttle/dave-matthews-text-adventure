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
        //Variables
        int maxLocations = Player.dave.GetLocationList().Count + 1;


        //Functions
        public static void GoToLocation(Location location) //probably shouldn't be static
        {
            // If your choice is 1 (the first choice)
            if (location.GetRoom() == "Home")
            {
                RunHomeStory();
            }
            //check to see if your choice is the same list value as the Home location
            if (Player.dave.m_location.GetRoom().IndexOf("Home") == 0)
            {
                Player.dave.m_location.SetRoom("Home");
            }
            if (Player.dave.m_location.GetRoom().IndexOf("McDonalds") == 0)
            {
                //go to mcdonalds
            }
            if (Player.dave.m_location.GetRoom().IndexOf("Daichi's House") == 0)
            {
                //go to daichi's house
            }
        }

        //public static void UseItem()
        //{
        //  if()
        //if(Player.dave.GetInventory().IndexOf() == 0)
        //}
        public static void MenuBuilder()
        {
            int maxItems = 3;
            System.Console.WriteLine("What will Dave do?");
            System.Console.WriteLine("------------------------");
            System.Console.WriteLine(" 1. Talk");
            System.Console.WriteLine(" 2. Items");
            System.Console.WriteLine(" 3. Locations");
            System.Console.WriteLine("------------------------");

            int position = Cursor.MakeChoice(maxItems);

            if (position == 1)
            {
                Console.WriteLine("Dave screamed out into the void.");
                System.Console.WriteLine("[Press the damn key, Shinji]");
                System.ConsoleKeyInfo keyPress = System.Console.ReadKey();
                MenuBuilder();
            }
            else if (position == 2)
            {
                Player.dave.GetInventory().List();
                System.Console.WriteLine(" Back");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~");

                Cursor.MakeChoice(maxItems);
                //UseItem();
                //MenuBuilder();
            }
            else if (position == 3)
            {
                Console.WriteLine("Where would you like to go today?");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~");
                Player.dave.PrintLocationList();
                Console.WriteLine(" Back");
                //An extra line is needed for this to work
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~");

                int choiceMade = Cursor.MakeChoice(maxItems + 1);
                Location selectedLocation = Player.dave.GetLocationList()[choiceMade - 1];
                GoToLocation(selectedLocation);
            }
        }

        public static void RunHomeStory()
        {
            Console.WriteLine("Dave opened his front door and caught a big juicy whiff of fresh air. As he was about to make his trek to his new lambo that he couldn't fit in his garage due to his extensive knowledge collection, an increasingly closer figure began invading his personal space. As he approached, Dave thought he recognized him as a portly version of his flautist he recently fired, complete with red Dave Matthews Band cap from the 2008 Northern Thailand tour. However, at second glance, he couldn't tell. He got his pepper spray can at the ready.");
            System.Console.WriteLine("[Press the damn key, Shinji]");
            System.ConsoleKeyInfo keyPress = System.Console.ReadKey();
        }

    }
}
