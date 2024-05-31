using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Free_Combat.Mechanics;

namespace Free_Combat.Characters
{
    internal class Blaze: Character
    {
        public static string name = "Blaze";
        public static int health = 100;
        public static int obbs = 12;
        public static int punchpower = 88;
        public static int kickpower = 76;
        public static int strenght = 95;
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
