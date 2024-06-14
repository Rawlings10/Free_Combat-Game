using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Free_Combat.Mechanics;

namespace Free_Combat.Characters
{
    internal class Kora : Character
    {
        public Kora(string name) : base(name, health, obbs, punchpower, kickpower, obbpower, IsSpecialAbilityUsed)
        {

        }

        public static string name = "Kora";
        public static int health = 100;
        public static int obbs = 15;
        public static int punchpower = 78;
        public static int kickpower = 92;
        public static int strenght = 83;
        public static int obbpower = 6;
        internal static bool IsSpecialAbilityUsed = false;

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
