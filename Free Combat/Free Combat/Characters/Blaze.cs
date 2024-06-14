using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Free_Combat.Mechanics;

namespace Free_Combat.Characters
{
    internal class Blaze: Character, IPlayersAbility
    {
       

        //Character blaze = new Character(name, health);

        internal int HP { get; set; } = 100;
        internal static string name = "Blaze";
        internal static int health = 100;
        internal static int obbs = 12;
        internal static int punchpower = 88;
        internal static int kickpower = 76;
        internal static int strenght = 95;
        internal static int obbpower = 2;
        internal static bool IsSpecialAbilityUsed = false;


        public Blaze(string name) : base(name, health, obbs, punchpower, kickpower, obbpower, IsSpecialAbilityUsed)
        {
            
        }

        public void SkillMove()
        {
            throw new NotImplementedException();
        }
    }
}
