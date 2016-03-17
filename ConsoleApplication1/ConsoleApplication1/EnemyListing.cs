using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaveMatthewsTextAdventure
{
    public class Enemy
    {
        public Enemy(string enemyName, float enemyHealth, float enemyMagic, int enemyStrength, int enemyIntelligence, int enemyEndurance, int enemySpeed, int enemyCharisma, int enemyAgility, int enemyWillpower, int enemyLuck)
        {

        }

        //Put in the name of an enemy, and call all of its values
        public static void EnemyCall(string enemyName)
        {
            Dictionary<string, string> enemyList = new Dictionary<string, string>();
            Dictionary<string, string>.ValueCollection valueColl = enemyList.Values;


            //Enemy list
            //The name you'll want to put in when accessing the dictionary is the one serving as the enemyName value.
            Enemy shinji = new Enemy("Shinji", 1, 0, 1, 1, 1, 1, 0, 1, 1, 0);
            enemyList.Add("Shinji", "Shinji");
            //
            


            if (enemyList.ContainsKey(enemyName))
            {

            }
        }
    }
    }

