using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var LegoCharacters = new List<figure>
            {
                new figure { Name = "Stan", Hair = "Baseball Cap", Head = "Jason Mask", Torso = "Hockey Pads", Legs = "Chain Mail", Accessories = "Hockey Stick", IsAFighter = true},
                new figure { Name = "Steven", Hair = "Mohawk", Head = "Beard", Torso = "Leather Vest", Legs = "Jeans", Accessories = "Anarchy Sign", IsAFighter = false},
                new figure { Name = "Duder", Hair = "Helmet", Head = "Face mask", Torso = "Armor", Legs = "Armor", Accessories = "Shotgun", IsAFighter = true}
            };

            foreach (var character in LegoCharacters)
            {
                Console.WriteLine(character.Fighting());
            }

            Console.Read();
        }
    }
}
