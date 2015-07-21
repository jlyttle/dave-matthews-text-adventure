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
        Boolean bossBattle;

         void PhysAttack(float physChanceToHit)
        {
           // physChanceToHit = 

            //If no critical hit
            // float attack = 1 * strength * weaponPhysStrength * luckEffect;
            
            //If critical hit
            //float critAttack = 1 * strength * weaponPhysStrength * luckEffect * critMultiplier;


        }

        void MagicAttack()
        {
            //If no critical hit
            // float attack = 1 * intelligence * weaponMagStrength * luckEffect;
            //If critical hit
            //float critAttack = 1 * intelligence * weaponMagStrength * luckEffect * critMultiplier;
        }

        void UseItem()
        {
            //Needs a way to open a list of items, then select one
        }

        void Flee(Random chanceToFleeGenerator, int chanceToFlee, Boolean fleeDetermined)
        {
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
                Program.Text("Dave scampered away with Big Mac in tow.", true);
                //End combat
            }
        }

        void ClassChange()
        {

        }

        void ConsultBigMac()
        {

        }

        void Talk()
        {

        }
    }
}
