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
        public static string name = "Taser";
        public static int health = 100;
        public static int obbs = 15;
        public static int punchpower = 78;
        public static int kickpower = 83;
        public static int strenght = 93;
        public static int obbpower = 3;

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
