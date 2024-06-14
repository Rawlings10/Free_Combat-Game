using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Free_Combat.Mechanics;

namespace Free_Combat.Characters
{
    internal class Vex : Character
    {
        public Vex(string name) : base(name, health, obbs, punchpower, kickpower, obbpower, IsSpecialAbilityUsed)
        {

        }

        public static string name = "Vex";
        public static int health = 100;
        public static int obbs = 15;
        public static int punchpower = 94;
        public static int kickpower = 69;
        public static int strenght = 93;
        public static int obbpower = 4;
        internal static bool IsSpecialAbilityUsed = false;

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
