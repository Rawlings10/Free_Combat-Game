using Free_Combat.Mechanics;
using System;

namespace Rawlings_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Character game = new Character();
            game.ChooseYourCharacter();
            game.CharacterChosen();
        }
    }
}
