using Free_Combat.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Free_Combat.Mechanics
{
    public class Game
    {
        public static int player1hp = 100;
        public static int player2hp = 100;

        public void ChooseYourCharacter()
        {
            Console.WriteLine("Choose your character");
            Console.WriteLine("1 --- Jake");
            Console.WriteLine("2 --- Blaze");
            Console.WriteLine("3 --- Taser");
            Console.WriteLine("4 --- Kyrexi");
            Console.WriteLine("5 --- Valtorix");
            Console.WriteLine("6 --- Kora");
            Console.WriteLine("7 --- Vex");
            Console.WriteLine("8 --- Zeph");
            Console.WriteLine("9 --- Krod");
            Console.WriteLine("10 --- Kim");

            Console.WriteLine();
            Console.WriteLine("Choose your character:");
            int choice = int.Parse(Console.ReadLine());

            Character pickplayer = choice switch
            {
                1 => new Jake(),
                2 => new Blaze(),
                3 => new Taser(),
                4 => new Kyrexi(),
                5 => new Valtorix(),
                6 => new Kora(),
                7 => new Vex(),
                8 => new Zeph(),
                9 => new Krod(),
                10 => new Kim(),
                _ => throw new ArgumentException("Invalid choice")
            };

            string[] characternames = { " ", "Jake", "Blaze", "Taser", " Kyrexi", "Valtorix", "Kora", "Vex", "Zeph", "Krod", "Kim" }; 
            Console.WriteLine($"You choose: {characternames[choice]}");          
        }

        public void Opponent()
        {
            Console.WriteLine("Choose your character");
            Console.WriteLine("1 --- Jake");
            Console.WriteLine("2 --- Blaze");
            Console.WriteLine("3 --- Taser");
            Console.WriteLine("4 --- Kyrexi");
            Console.WriteLine("5 --- Valtorix");
            Console.WriteLine("6 --- Kora");
            Console.WriteLine("7 --- Vex");
            Console.WriteLine("8 --- Zeph");
            Console.WriteLine("9 --- Krod");
            Console.WriteLine("10 --- Kim");
        }
    } 
}
