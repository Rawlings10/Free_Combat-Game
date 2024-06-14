using Free_Combat.Mechanics;
using System;

namespace Rawlings_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Character game = new Character("player", 100, 0, 0, 0, 0, false);
            game.ChoosenCharacter();           
        }
    }
}
