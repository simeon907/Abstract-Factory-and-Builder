using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Flyweight
{
    public class CharacterFactory
    {
        private Dictionary<string, Character> characters = new Dictionary<string, Character>();

        public Character GetCharacter(string key)
        {
            Character character = null;
            if (!characters.TryGetValue(key, out character))
            {
                switch (key)
                {
                    case "barbarian":
                        character = new Barbarian();
                        break;
                    case "archer":
                        character = new Archer();
                        break;
                    default:
                        character = new Default();
                        break;
                }
                characters.Add(key, character);
            }
            return character;
        }
    }
}
