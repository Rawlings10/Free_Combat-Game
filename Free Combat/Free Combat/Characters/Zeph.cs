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
        public static string name = "Zeph";
        public static int health = 100;
        public static int obbs = 15;
        public static int punchpower = 94;
        public static int kickpower = 85;
        public static int strenght = 86;
        public static int obbpower = 2;

        internal override void PlayerControl()
        {
            throw new NotImplementedException();
        }

        internal override void SkillMove()
        {
            throw new NotImplementedException();
        }

        internal override void SpecialAbility()
        {
            throw new NotImplementedException();
        }
    }
}
