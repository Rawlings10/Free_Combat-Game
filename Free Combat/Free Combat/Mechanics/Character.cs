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
    public class Character
    {
        public int PlayerHP { get; set; }
        public string Name { get; set; }

        internal string[] players = { "Player1", "Player2" };

        internal static bool IsSpecialAbilityUsed = false;

        public Character(string name, int playerHP) 
        {
            this.Name = name;
            this.PlayerHP = playerHP;
        }

        public void ChooseYourCharacter()
        {
            List<Func<string, Character>> SelectPlayer = new List<Func<string, Character>>()
            {
                name => new Blaze(name),
                name => new Jake(name),
                name => new Taser(name),
                name => new Kyrexi(name),
                name => new Valtorix(name),
                name => new Kora(name),
                name => new Vex(name),
                name => new Zeph(name),
                name => new Krod(name),
                name => new Kim(name),
                _ => throw new ArgumentException("Invalid choice"),
            };

            List<string> characterNames = new List<string>()
            {
                "Blaze",
                "Jake",
                "Taser",
                "Kyrexi",
                "Valtorix",
                "Kora",
                "Vex",
                "Zeph",
                "Krod",
                "Kim",
            }; 

            for (int i = 0; i < players.Length; i++) 
            {
                Console.WriteLine($"{players[i]} Choose your Character");

            }
        }
        
        public void CharacterChosen()
        {
            Console.WriteLine($"{players[0]} choose {player1character}");
            Console.WriteLine($"{players[1]} choose {player2character}");           
        }

        public static void Punch(int punchpower)
        {
            punchpower /= 12;
            Random random = new Random();
            punchpower = random.Next(punchpower, punchpower + 4);
            PlayerHP -= punchpower;
        }

        public static void Kick(int kickpower)
        {
            kickpower /= 12;
            Random random = new Random();
            kickpower = random.Next(kickpower, kickpower + 4);
            PlayerHP -= kickpower;
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
    } 
}
