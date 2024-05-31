using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Free_Combat.Mechanics
{
    public abstract class Character
    {
        internal abstract void SkillMove();

        internal abstract void SpecialAbility();

        internal abstract void PlayerControl();
    }
}
