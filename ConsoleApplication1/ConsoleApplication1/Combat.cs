using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Combat
    {

        //HP/Hearts
        int doritos;

        //Cholesterol/Magic
        float mountainDew;

        //burgerPower
        //Affects the damage multiplier for physical attacks
        float strength = 10;

        //glucose intake
        //Affects the damage multiplier for magical attacks
        int intelligence = 10;

        // body fat
        //Affects overall HP/Hearts
        int endurance = 10;

        // greasiness
        //Affects turn order, higher levels of speed can lead to multiple hits, mildly affects chance to dodge
        int speed = 10;

        //Happy Meal Toys
        //Affects chance of a successful persuasion
        int charisma = 10;

        //Playground skills
        //Affects chance of dodging attacks, critical hits, maybe allow for alternative paths/shortcuts?
        int agility = 10;

        //Desire for a big mac
        //Reduces cholesterol/Mountain Dew consumption
        int willpower = 10;
        
        // Favor of Ronald
        //Mildly affect everything
        static float luck = 10;
        float luckModifier = luck;

        //The effect a weapon has on a physical attack
        float weaponPhysStrength = 1;

        //The effect a weapon has on a magical attack
        int weaponMagStrength = 1;
        
        //The multiplier for critical hits
        void CriticalHit(float critDamageMultiplier, float chanceToCritMultiplier)
        {
            critDamageMultiplier = 2;
            chanceToCritMultiplier = 0.01F * agility;

        }
        

        // Represents whether or not a boss battle is active
       static Boolean bossBattle;
        // Triggers end of combat if flee is successful; this to prevent exp gain, etc.
        static Boolean endOfCombatByFleeing;
       

        static void PhysAttack(float physChanceToHit)
        {
           // physChanceToHit = 

            //If no critical hit
            // float attack = 1 * strength * weaponPhysStrength * luckEffect;
            
            //If critical hit
            //float critAttack = 1 * strength * weaponPhysStrength * luckEffect * critMultiplier;


        }

       static void MagicAttack()
        {
            //If no critical hit
            // float attack = 1 * intelligence * weaponMagStrength * luckEffect;
            //If critical hit
            //float critAttack = 1 * intelligence * weaponMagStrength * luckEffect * critMultiplier;
        }

       static void UseItem()
        {
            //Use if statements.  If an item is in the inventory, then a print command with its name occurs.
            //For item selection, we might want to have the user type the item name in.
            //If an item is selected, we should have its method called, with all of the effects inside of it.
        }

       public static void Flee()
        {
            Random chanceToFleeGenerator = new Random();
            int chanceToFlee = new int();
            Boolean fleeDetermined = new Boolean();

            if (bossBattle == true)
            {
                chanceToFlee = 0;
            }
            else chanceToFlee = chanceToFleeGenerator.Next(100);

            if (chanceToFlee <= 50)
            {
                fleeDetermined = false;
            }
            else fleeDetermined = true;

            if (fleeDetermined == true)
            {
                Program.Text("Dave scampered away with Big Mac in tow.", true, false);
                endOfCombatByFleeing = true;
            }
        }

       static void ClassChange()
        {

        }

       static void ConsultBigMac()
        {

        }

       static void Talk()
        {

        }

        
        // /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Combat interface and non-command elements below.  Pico, I feel fully justified in using extra white space to partition this off.



        static void Targeting()
        {

        }

        protected static int CombatInterface()
        {
            Program.Text("A blasphemer who hates McDonald's appeared!", true, false);
            Program.Text("What will Dave do?", false, false);
            Program.Text("1.  Attack with weapon", false, false);
            Program.Text("2.  Attack with cholesterol", false, false);
            Program.Text("3.  Use an item", false, false);
            Program.Text("4.  Change class", false, false);
            Program.Text("5.  Talk to opponent", false, false);
            Program.Text("6.  Consult the Big Mac", false, false);
            Program.Text("7.  Flee", false, false);

            ConsoleKeyInfo decision;
            while (true)
            {
                decision = System.Console.ReadKey();
                System.Console.Write("\r");
                if (decision.Key == ConsoleKey.D1)
                {
                    //The parameter value needs to be changed later
                    PhysAttack(1);
                }
                if (decision.Key == ConsoleKey.D2)
                {
                    MagicAttack();
                }
                if (decision.Key == ConsoleKey.D3)
                {
                    UseItem();
                }
                if (decision.Key == ConsoleKey.D4)
                {
                    ClassChange();
                }
                if (decision.Key == ConsoleKey.D5)
                {
                    Talk();
                }
                if (decision.Key == ConsoleKey.D6)
                {
                    ConsultBigMac();
                }
                if (decision.Key == ConsoleKey.D7)
                {
                    Flee();
                    if (Combat.endOfCombatByFleeing == true)
                    {
                        return 1;
                    }
                }
                //This probably needs to be moved
                System.Console.WriteLine("Don't be a Daichster, press a listed number.");
            }
        }
    }
}
