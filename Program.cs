using System;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

namespace Role_playing_game
{
    class Program
    {
        private static int counter;

        static void Main(string[] args)
        {
            Menu();
        }

        static void Play(Character mycharacter)
        {
            Monster monster = new Monster("Demonic wolf");
            bool victory = true;
            bool next = false;

            while (!monster.Dead())
            {
                // MONSTER ROUND    
                Console.ForegroundColor = ConsoleColor.Red;
                monster.Attack(mycharacter);
                Console.WriteLine();
                Console.ReadKey(true);

                if(mycharacter.Dead())
                {
                    victory = false;
                    break;
                }

                // CHARACTER ROUND 
                Console.ForegroundColor= ConsoleColor.Green;
                mycharacter.Attack(monster);
                Console.WriteLine();
                Console.ReadKey(true);  
            }

            if(victory)
            {
                mycharacter.WinXP(5);
                counter++;
                if (counter == 3)
                {
                    mycharacter.Rest();
                    counter = 0;
                }

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine();
                Console.WriteLine(mycharacter.Stats());
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();

                while(!next)
                {
                    Console.WriteLine("Next room ? (Y/N)");
                    string input = Console.ReadLine().ToUpper();
                    if(input == "Y")
                    {
                        next = true;
                        Play(mycharacter);
                    }
                    else if(input == "N") Environment.Exit(0);

                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine();
                Console.WriteLine("You lost ...");
                Console.ReadKey();
            }

        }

        static void Menu()
        {
            string namecharacter ="";
            counter = 0;

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("The role-playing game");
            Console.WriteLine();
            while (String.IsNullOrEmpty(namecharacter))
            {
                Console.WriteLine("Write the name of your character : ");
                namecharacter = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("Choose your character : ");
            Console.WriteLine("1. Warrior \n2. Archer \n3. Sorcerer \nExit");
            Console.WriteLine();

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Warrior " + namecharacter + " , let's fight !");
                    Console.WriteLine();
                    Play(new Warrior(namecharacter));
                    break;
                case "2":
                    Console.WriteLine("Archer " + namecharacter + " , let's fight !");
                    Console.WriteLine();
                    Play(new Archer(namecharacter));
                    break;
                case"3":
                    Console.WriteLine("Sorcerer " + namecharacter + " , let's fight !");
                    Console.WriteLine();
                    Play(new Sorcerer(namecharacter));
                    break;
                case"4":
                    break;
            }            
        }
    }
}