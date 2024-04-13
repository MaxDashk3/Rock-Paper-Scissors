using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    internal static class RockPaperScissors
    {
        static string[] signs = {"Rock", "Paper", "Scissors"};
        static int Player1;
        static int Player2;

        static public void StartGame()
        {
            Console.WriteLine("Game started!");
            Console.WriteLine("Select game mode: ");
            Console.WriteLine("1) vs Computer");
            Console.WriteLine("2) vs Player");

            char choice = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (choice)
            {
                case '1':
                    VSComputer();
                    break;
                case '2':
                    VSPlayer();
                    break;
            }
        }

        static int PlayerInput() 
        {
            Console.WriteLine("choose a sign:");
            Console.WriteLine("1) Rock");
            Console.WriteLine("2) Paper");
            Console.WriteLine("3) Scissors");

            char choice = Console.ReadKey().KeyChar;
            Console.WriteLine();

            return Convert.ToInt16(choice.ToString()) - 1;
        }

        static void VSComputer()
        {
            Console.Write("Player, ");
            Player1 = PlayerInput();
            
            Random rand = new Random();

            Player2 = rand.Next(3);

            int result = Player1 - Player2;

            Console.WriteLine("Player: " + signs[Player1]);
            Console.WriteLine("Computer: " + signs[Player2]);

            switch (result) 
            {
                case 0:
                    Console.WriteLine("Draw!");
                    break;
                case 1 or -2:
                    Console.WriteLine("Player wins!");
                    break;
                case -1 or 2:
                    Console.WriteLine("Computer wins!");
                    break;
            }
        }

        static void VSPlayer()
        {
            Console.Write("Player 1, ");
            Player1 = PlayerInput();
            Console.Clear();

            Console.Write("Player 2, ");
            Player2 = PlayerInput();
            Console.Clear();

            int result = Player1 - Player2;

            Console.WriteLine("Player 1: " + signs[Player1]);
            Console.WriteLine("Player 2: " + signs[Player2]);

            switch (result)
            {
                case 0:
                    Console.WriteLine("Draw!");
                    break;
                case 1 or -2:
                    Console.WriteLine("Player 1 wins!");
                    break;
                case -1 or 2:
                    Console.WriteLine("Player 2 wins!");
                    break;
            }
        }
    }
}
