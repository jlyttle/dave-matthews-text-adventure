using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaveMatthewsTextAdventure
{
    class Inventory
    {
        int m_maxItems;
        List<Item> m_itemList;
        public Inventory(int maxItems)
        {
            //Create a list of items
            m_itemList = new List<Item>();
            m_maxItems = maxItems;
            //m_itemList.Add(new Item(Item.GetItemByNameInDictionary("Money Wad")));
        }

        public void Add(Item item)
        {
            if (m_itemList.Count >= m_maxItems)
            {
                Console.WriteLine("I'm sorry Dave, I can't let you do that. You can't hold any more stuff in your pants. ;)");
            }
            else
            {
                m_itemList.Add(item);
            }
        }
        public void List()
        {
            //for each item in list, print it out on a new line
            for (m_itemList.ForEach)
                {

                }
        }
    }
}
