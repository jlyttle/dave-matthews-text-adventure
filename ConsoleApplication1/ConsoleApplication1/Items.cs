using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum DaveMathewsItemType
{
    ITEM_INVALID = -1,
    ITEM_CUP,
    ITEM_DRINK,
    ITEM_CONTAINER,
    ITEM_FOOD,
    ITEM_SPECIAL,
    NUM_OF_VALID_ITEM_TYPES
}

namespace DaveMatthewsTextAdventure
{
    class Item
    {
        public static Dictionary<string, Item> s_Dictionary_Of_Items = new Dictionary<string, Item>();

        public static void LoadItemsIntoDictinoary()
        {
            //Drinks
            //s_Dictionary_Of_Items.Add("McFlurry", new Item(DaveMathewsItemType.ITEM_DRINK, "Cup", "McFlurry"));
            AddOrUpdateItemToDictionary(new Item(DaveMathewsItemType.ITEM_DRINK, "Cup", "McFlurry", 1));
            AddOrUpdateItemToDictionary(new Item(DaveMathewsItemType.ITEM_DRINK, "Cup", "Coffee", 1));
            AddOrUpdateItemToDictionary(new Item(DaveMathewsItemType.ITEM_DRINK, "Cup", "Tea", 1));
            AddOrUpdateItemToDictionary(new Item(DaveMathewsItemType.ITEM_DRINK, "Plastic Bottle", "Coke", 1));
            AddOrUpdateItemToDictionary(new Item(DaveMathewsItemType.ITEM_DRINK, "Plastic Bottle", "Diet Coke", 1));
            AddOrUpdateItemToDictionary(new Item(DaveMathewsItemType.ITEM_DRINK, "Cup", "Iced Coffee", 1));
            AddOrUpdateItemToDictionary(new Item(DaveMathewsItemType.ITEM_DRINK, "Cup", "Iced Tea", 1));
            AddOrUpdateItemToDictionary(new Item(DaveMathewsItemType.ITEM_DRINK, "Box", "Juice Box", 1));
            AddOrUpdateItemToDictionary(new Item(DaveMathewsItemType.ITEM_DRINK, "Box", "Iced Juice Box", 1));

            //Food
            AddOrUpdateItemToDictionary(new Item(DaveMathewsItemType.ITEM_FOOD, "", "Big Mac", 1));

            //Special
            AddOrUpdateItemToDictionary(new Item(DaveMathewsItemType.ITEM_SPECIAL, "", "Money Wad", 1));
        }
        public static void AddOrUpdateItemToDictionary(Item item)
        {
            if(item == null)
            {
                return;
                //if item is null, do an early return
            }
            //Dictionary, key = string/name, value = Item.
            Item test = null;
            s_Dictionary_Of_Items.TryGetValue(item.GetItemName(), out test); 
            if(test != null) //test to see if item name already set in the dictionary
            {
                s_Dictionary_Of_Items[item.GetItemName()] = item;
                //^ updates item located at key = item name.
            }
            else
            {
                s_Dictionary_Of_Items.Add(item.GetItemName(), item);
                // Adds key pair to dictionary if it doesn't exist
            }
        }
        public static Item GetItemByNameInDictionary(string name)
        {
            if (s_Dictionary_Of_Items.ContainsKey(name))
            {
                return s_Dictionary_Of_Items[name];
            }
            return null;
        }


        //variables
        private DaveMathewsItemType m_type;
        private string m_name;
        private string m_container;
        private int m_quantity;

        //constructors
        public Item(DaveMathewsItemType type = DaveMathewsItemType.ITEM_CUP, string container = "", string name = "", int quantity = 1)
        {
            m_type = type;
            m_name = name;
            m_container = container;
            m_quantity = quantity;
        }
        public Item(Item other)
        {
            //copy constructor
            m_type = other.GetItemType();
            m_name = other.GetItemName();
            m_container = other.GetContainer();
            m_quantity = other.GetQuantity();
        }

        //setters
        public void SetItemType(DaveMathewsItemType type) { m_type = type; }
        public void SetItemName(string name)
        {
            m_name = name;
        }
        public void SetContainer(string container)
        {
            m_container = container;
        }
        public void SetQuantity(int quantity)
        {
            m_quantity = quantity;
        }

        //getters
        public DaveMathewsItemType GetItemType() { return m_type; }
        public string GetItemName()
        {
            return m_name;
        }
        public string GetContainer()
        {
            return m_container;
        }
        public int GetQuantity()
        {
            return m_quantity;
        }

        public void PrintToConsole()
        {
            Console.WriteLine(m_name + ": " + m_quantity);
        }
        // 
        //         public override int GetHashCode()
        //         {
        //             return base.GetHashCode();
        //         }
        //         public override bool Equals(object obj)
        //         {
        //             try
        //             {
        //                 return (bool)(this == (Item)obj);
        //             }
        //             catch
        //             {
        //                 return false;
        //             }
        //         }


    }
}
