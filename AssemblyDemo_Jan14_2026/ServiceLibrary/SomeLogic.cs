using System.Numerics;

namespace ServiceLibrary
{
    public class SomeLogic
    {
        #region Attributes
        int id;
        string name;
        string addr;
        #endregion

        #region Properties

        //the attributes are encapsulated using properties as the attributes are private
        public int ID
        {
            get { return id; }
            set
            {
                id = value;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }

        public string Addr
        {
            get { return addr; }
            set
            {
                addr = value;
            }

        }
        #endregion

        //constructor - a method created to initialize the privatte attributes
        public SomeLogic()
        {

        }

        public SomeLogic(int yourID, string yourName, string yourAddress)
        {

        }

        #region Methods
        public int Add(int a, int b)
        {
            return a + b;
        }

        public List<Object> ShowAll()
        {
            return new List<Object>(); 
        }

        //to show the list of players
        public List<Player> ShowAllPlayers() {
            return new List<Player>() { 
                new Player() { PlayerID = 1, PlayerName = "Alice", Skills = new List<string> { "Shooting", "Passing" } },
                new Player() { PlayerID = 2, PlayerName = "Bob", Skills = new List<string> { "Dribbling", "Defense" } },
                new Player() { PlayerID = 3, PlayerName = "Charlie", Skills = new List<string> { "Speed", "Stamina" } },
                new Player() { PlayerID = 4, PlayerName = "Diana", Skills = new List<string> { "Leadership", "Strategy" } },
                new Player() { PlayerID = 5, PlayerName = "Ethan", Skills = new List<string> { "Agility", "Vision" } }
            };
        }
        #endregion
    }
}
