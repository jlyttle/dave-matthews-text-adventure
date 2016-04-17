using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum DaveMatthewsWorld
{
    WORLD_INVALID = -1,
    EARTH,
    NICAEA
}

namespace DaveMatthewsTextAdventure
{
    class Location
    {
        //variables
        private DaveMatthewsWorld m_world;
        private string m_room;

        //constructors
        public Location(DaveMatthewsWorld world = DaveMatthewsWorld.EARTH, string room = "")
        {
            m_world = world;
            m_room = room;
        }
        public Location(Location other)
        {
            m_world = other.GetWorld();
            m_room = other.GetRoom();
        }

        //setters
        public void SetWorld(DaveMatthewsWorld world)
        {
            m_world = world;
        }
        public void SetRoom(string room)
        {
            m_room = room;
        }

        //getters
        public DaveMatthewsWorld GetWorld() { return m_world; }
        public string GetRoom()
        {
            return m_room;
        }

        public static Dictionary<string, Location> s_Dictionary_Of_Rooms = new Dictionary<string, Location>();
        public static void LoadLocationsIntoDictinoary()
        {
            //Earth
            AddOrUpdateLocationToDictionary(new Location(DaveMatthewsWorld.EARTH, "Home"));
            AddOrUpdateLocationToDictionary(new Location(DaveMatthewsWorld.EARTH, "McDonalds"));
            AddOrUpdateLocationToDictionary(new Location(DaveMatthewsWorld.EARTH, "Sushi Bar"));
            //Nicaea

        }
        public static void AddOrUpdateLocationToDictionary(Location location)
        {
            if (location == null)
            {
                return;
            }
            if (s_Dictionary_Of_Rooms.ContainsKey(location.GetRoom()))
            {
                s_Dictionary_Of_Rooms[location.GetRoom()] = location;
            }
            else
            {
                s_Dictionary_Of_Rooms.Add(location.GetRoom(), location);
                // Adds key pair to dictionary if it doesn't exist
            }
        }
        public static Location GetRoomByNameInDictionary(string name)
        {
            if (s_Dictionary_Of_Rooms.ContainsKey(name))
            {
                return s_Dictionary_Of_Rooms[name];
            }
            return null;
        }

        //public string room()
    }
}
