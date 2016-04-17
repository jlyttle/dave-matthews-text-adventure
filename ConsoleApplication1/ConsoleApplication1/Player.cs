using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaveMatthewsTextAdventure
{
    class Player
    {
        public static Player dave = new Player();
        //permanent variables, belong to the class (in the scope of the class)
        public int m_maxHealth = 100;
        public int m_health;
        public Location m_location;
        public Inventory m_inventory;
        public List<Location> m_locationList;

        public void AddLocation(Location location)
        {
            m_locationList.Add(location);
        }       

        public Player()
        {
            m_health = m_maxHealth;
            m_location = new Location(DaveMatthewsWorld.EARTH, "Home");
            m_locationList = new List<Location>();
            m_locationList.Add(m_location);
            m_locationList.Add(new Location(DaveMatthewsWorld.NICAEA, "Daichi's House"));
            m_locationList.Add(new Location(DaveMatthewsWorld.NICAEA, "McDonald's"));
            m_inventory = new Inventory(10);
            m_inventory.Add(new Item(DaveMathewsItemType.ITEM_SPECIAL, "", "Money Wad", 1));
        }

        public List<Location> GetLocationList()
        {
            return m_locationList;
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
        public void PrintLocationList()
        {
            //for each item in list, print it out on a new line
            m_locationList.ForEach(delegate (Location location)
            {
               location.PrintToConsole();
            });
        }
    }
}
