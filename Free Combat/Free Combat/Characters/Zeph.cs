using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Free_Combat.Mechanics;

namespace Free_Combat.Characters
{
    internal class Zeph : Character
    {
        public Zeph(string name) : base(name, 100)
        {

        }

        public static string name = "Zeph";
        public static int health = 100;
        public static int obbs = 15;
        public static int punchpower = 94;
        public static int kickpower = 85;
        public static int strenght = 86;
        public static int obbpower = 2;

        public void PlayerControl(Character player, ConsoleKey key)
        {
            throw new NotImplementedException();
        }

        public void SkillMove()
        {
            throw new NotImplementedException();
        }
    }
}
