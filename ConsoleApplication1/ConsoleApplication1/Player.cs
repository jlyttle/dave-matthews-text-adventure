using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaveMatthewsTextAdventure
{
    class Player
    {
        //permanent variables, belong to the class (in the scope of the class)
        public int m_maxHealth = 100;
        public int m_health;
        public Location m_location;
        public Inventory m_inventory;
        public static Player dave = new Player();

        public Player()
        {
            m_health = m_maxHealth;
            m_location = new Location(DaveMatthewsWorld.EARTH, "Home");
            m_inventory = new Inventory(10);
            m_inventory.Add(new Item(DaveMathewsItemType.ITEM_SPECIAL, "", "Money Wad", 1));
        }

        public Inventory GetInventory()
        {
            return m_inventory;
        }

        public int DecreaseHealth(int amountToDecreaseBy)
        {
            int testHealth = m_health - amountToDecreaseBy;
            if(testHealth <= 0)
            {
                m_health = 0;
                return m_health;
            }
            else
            {
                m_health = testHealth;
                return testHealth;
            }
        }
        public int HealthIncrement(int amountToIncrementBy)
        {
            m_maxHealth = m_maxHealth + amountToIncrementBy;
            return m_maxHealth;
        }
    }
}
