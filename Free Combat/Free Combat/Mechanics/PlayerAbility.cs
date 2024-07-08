using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Free_Combat.Mechanics
{
    public interface IPlayersAbility
    {
        internal abstract void PlayerControl(Character player, ConsoleKey key);
    }
}
