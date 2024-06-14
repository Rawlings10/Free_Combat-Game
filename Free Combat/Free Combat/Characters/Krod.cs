using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Free_Combat.Mechanics;

namespace Free_Combat.Characters
{
    internal class Krod : Character
    {
        public Krod(string name) : base(name, health, obbs, punchpower, kickpower, obbpower, IsSpecialAbilityUsed)
        {

        }

        public static string name = "Krod";
        public static int health = 100;
        public static int obbs = 15;
        public static int punchpower = 84;
        public static int kickpower = 84;
        public static int strenght = 88;
        public static int obbpower = 5;
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
