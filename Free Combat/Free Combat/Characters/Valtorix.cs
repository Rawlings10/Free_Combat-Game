using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Free_Combat.Mechanics;

namespace Free_Combat.Characters
{
    internal class Valtorix : Character
    {
        public Valtorix(string name) : base(name, health, obbs, punchpower, kickpower, obbpower, IsSpecialAbilityUsed)
        {

        }

        public static string name = "Valtorix";
        public static int health = 100;
        public static int obbs = 15;
        public static int punchpower = 95;
        public static int kickpower = 72;
        public static int strenght = 82;
        public static int obbpower = 2;
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
