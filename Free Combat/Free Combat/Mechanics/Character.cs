using Free_Combat.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Free_Combat.Mechanics
{
    public class Game
    {
        public static int player1hp = 100;
        public static int player2hp = 100;
        public static string player1character;
        public static string player2character;
        internal string[] players = { "Player1", "Player2" };
        internal static bool IsSpecialAbilityUsed = false;

        public void ChooseYourCharacter()
        {
            for(int i = 0; i < players.Length; i++)
            {
                Console.WriteLine($"{players[i]} Choose your character");
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
                SetTimer(500);
                Console.Clear();

                if(i == 0)
                {
                    player1character = characternames[choice];                    
                }
                else
                {
                    player2character = characternames[choice];
                }
            }         
        }
        public void CharacterChosen()
        {
            Console.WriteLine($"{players[0]} choose {player1character}");
            Console.WriteLine($"{players[1]} choose {player2character}");           
        }

        public static int Punch(int punchpower)
        {
            punchpower /= 12;
            Random random = new Random();
            punchpower = random.Next(punchpower, punchpower + 4);
            return punchpower;
        }

        public static int Kick(int kick)
        {
            kick /= 12;
            Random random = new Random();
            kick = random.Next(kick, kick + 4);
            return kick;
        }

        public static bool SpecialAbility(int obbs, int obbspower)
        {
            if (IsSpecialAbilityUsed == false)
            {
                int damage = obbs + obbspower;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Obbs Damage!!!");
                Console.ResetColor();
            } 
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Special Ability has been used!!!");
                Console.ResetColor();
            }
            return IsSpecialAbilityUsed = true;           
        }

        public static void SetTimer(int time)
        {
            Thread.Sleep(1000);           
        }

        internal static void Player1AttackDamage(int damagedone)
        {
            damagedone = player2hp - Punch();
        }    

        public static int FightScene(int health1, int health2)
        {
            while (health1 > 0 && health2 > 0)
            {

            }  
        }        
    } 
}
