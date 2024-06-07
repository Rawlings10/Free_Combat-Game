using Free_Combat.Mechanics;
using System;
using System.Security.Cryptography;

namespace Rawlings_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.ChooseYourCharacter();
            Console.Clear();
            game.CharacterChosen();
        }
    }
}
