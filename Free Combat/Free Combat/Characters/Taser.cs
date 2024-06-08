using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Free_Combat.Mechanics;

namespace Free_Combat.Characters
{
    internal class Taser : Character
    {
        public Taser(string name) : base(name, 100)
        {

        }

        public static string name = "Taser";
        public static int health = 100;
        public static int obbs = 15;
        public static int punchpower = 78;
        public static int kickpower = 83;
        public static int strenght = 93;
        public static int obbpower = 3;

        public void PlayerControl(ConsoleKey key)
        {
            throw new NotImplementedException();
        }

        public void SkillMove()
        {
            throw new NotImplementedException();
        }
    }
}
