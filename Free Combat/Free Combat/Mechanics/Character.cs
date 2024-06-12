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
        public int PlayerHP { get; protected set; }
        public string Name { get; set; }

        internal static bool IsSpecialAbilityUsed = false;
        private static Character currentCharacter;

        public Character(string name, int playerHP) 
        {
            this.Name = name;
            this.PlayerHP = playerHP;
        }

        public void ChoosenCharacter()
        {
            List<Func<string, Character>> choosenPlayer = new List<Func<string, Character>>()
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

            Console.WriteLine("Player 1, choose your Character: ");
            Character player1 = Selectplayer("Player1", choosenPlayer, characterNames);
            Console.WriteLine();
            Console.WriteLine("Player 2, choose your Character: ");
            Character player2 = Selectplayer("Player2", choosenPlayer, characterNames);
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{player1.Name} ({player1.GetType().Name})");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("              vs");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"                 {player2.Name} ({player2.GetType().Name})");

            SetTimer(2000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("FIGHT");
            Console.ResetColor();
            
            while(player1.PlayerHP >= 0 && player2.PlayerHP >= 0)
            {
                ConsoleKey key = Console.ReadKey(true).Key;
                UtilizeControl(player1, key);
                UtilizeControl(player2, key);
            }
        }

        public static Character Selectplayer(string name, List<Func<string, Character>> selectPlayer, List<string> classNames)
        {
            for(int i = 0; i < classNames.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {classNames[i]}");
            }

            int choice;
            do
            {
                Console.Write($"Select a character (1-{classNames.Count}): " );
            }
            while(!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > classNames.Count);

            return selectPlayer[choice - 1](name);
        }

        public void Punch(int punchpower)
        {
            punchpower /= 12;
            Random random = new Random();
            punchpower = random.Next(punchpower, punchpower + 4);
            PlayerHP -= punchpower; 
        }

        public void Kick(int kickpower)
        {
            kickpower /= 12;
            Random random = new Random();
            kickpower = random.Next(kickpower, kickpower + 4);
            PlayerHP -= kickpower;
        }

        public bool SpecialAbility(int obbs, int obbspower)
        {
            if (IsSpecialAbilityUsed == false)
            {
                int damage = obbs + obbspower;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Obbs Damage!!!");
                Console.WriteLine($"-{ damage}");
                PlayerHP -= damage;
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
        public void UtilizeControl(IPlayersAbility Control, ConsoleKey key)
        {
            Control.PlayerControl(key);            
        }

        public static void SetTimer(int time)
        {
            Thread.Sleep(1000);           
        }     
    } 
}
