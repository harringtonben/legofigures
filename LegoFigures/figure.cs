using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoFigures
{
    class figure
    {
        public string Name { get; set; }
        public string Hair { get; set; }
        public string Head { get; set; }
        public string Torso { get; set; }
        public string Legs { get; set; }
        public string Accessories { get; set; }
        public bool IsAFighter { get; set; }

        public string Fighting()
        {
            return IsAFighter
                ? $"Because {Name} has a {Hair}, {Head}, {Torso}, {Legs} and {Accessories}, they would be fine in a fight, and probably do some damage."
                : $"Because {Name} has a {Hair}, {Head}, {Torso}, {Legs} and {Accessories}, they would probably get stomped around in a fight.";
        }
    }
}
