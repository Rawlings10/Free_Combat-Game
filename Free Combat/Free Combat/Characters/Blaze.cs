using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Free_Combat.Mechanics;

namespace Free_Combat.Characters
{
    internal class Blaze: IPlayersAbility
    {
        internal int HP { get; set; } = 100;
        internal static string name = "Blaze";
        internal static int health = 100;
        internal static int obbs = 12;
        internal static int punchpower = 88;
        internal static int kickpower = 76;
        internal static int strenght = 95;
        internal static int obbpower = 2;

        public void PlayerControl(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.A:
                    Game.Punch(punchpower);
                    break;
                case ConsoleKey.B:
                    Game.Kick(kickpower);
                    break;
                case ConsoleKey.W:
                    Game.SpecialAbility(obbs, obbpower);
                    break;
            }
        }

        public void SkillMove()
        {
            throw new NotImplementedException();
        }
    }
}
