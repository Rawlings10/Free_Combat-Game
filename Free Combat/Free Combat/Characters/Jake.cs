﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Free_Combat.Mechanics;

namespace Free_Combat.Characters
{
    internal class Jake : Character, IPlayersAbility
    {
        public static string name = "Jake";
        public static int health = 100;
        public static int obbs = 12;
        public static int punchpower = 78;
        public static int kickpower = 83;
        public static int strenght = 93;
        public static int obbpower = 3;
        internal static bool IsSpecialAbilityUsed = false;

        public Jake(string name) : base(name, health, obbs, punchpower, kickpower, obbpower, IsSpecialAbilityUsed)
        {

        }

        public void SkillMove()
        {
            throw new NotImplementedException();
        }
    }
}
