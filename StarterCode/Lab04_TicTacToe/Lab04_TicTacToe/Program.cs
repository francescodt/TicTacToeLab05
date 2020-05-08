using Lab04_TicTacToe.Classes;
using System;

namespace Lab04_TicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO THE TIC TAC TOE GAME");
            StartGame();

        }

       public static void StartGame()
        {

            Console.WriteLine("please enter the name of the first player");
            string player1input =  Console.ReadLine();
            Player player1  = new Player();
            player1.Name = player1input;

            Console.WriteLine("please enter the name of the second player");
            string player2input = Console.ReadLine();
            Player player2 = new Player();
            player2.Name = player2input;

            Game game  = new Game(player1, player2);

            game.Play();
           


            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 

        }


    }
}
