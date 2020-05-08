using Lab04_TicTacToe.Classes;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using Xunit;

namespace Tic_Tac_Toe_Tests
{
    public class UnitTest1
    {

        /// <summary>
        /// If the board changes correctly
        /// that we can't rewrite or resubmit choices
        /// if the position doesn't exist
        /// winner / draw - program stop
        /// taking turns
        /// </summary>
        

        [Fact]
        public void Test_for_winner()
        {
            
            Player player1  = new Player();
            Player player2  = new Player();
            Game game = new Game(player1,  player2);

            bool result= game.CheckForWinner(null);

            Assert.False(result);
        }

        [Fact]
        public void Check_player_take_turns()
        {
            //Arrange
            Player player1 = new Player();
            player1.Name = "Sihem";

            Player player2 = new Player();
            player2.Name = "Francesco";

            player1.IsTurn = true;
            player2.IsTurn = false;

            //Act
            Game nowGameBoard = new Game(player1, player2);
            Player current = nowGameBoard.NextPlayer();


            //Assert
            Assert.Equal("Sihem", current.Name);
        }

        
    }
}
