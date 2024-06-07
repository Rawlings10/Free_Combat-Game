﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Free_Combat.Mechanics
{
    interface IPlayersAbility
    {
        internal abstract void SkillMove();
        internal abstract void PlayerControl(ConsoleKey key);
    }
}