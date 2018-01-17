using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore
{
    class Program
    {
        static void Main(string[] args)
        {
            GameBoard Game = new GameBoard();
            Game.newGameBoard();
            Player PlayerX = new Player();
            PlayerX.setPlayer(identity.X);
            Player PlayerO = new Player();
            PlayerO.setPlayer(identity.O);
            Player currentPlayer;
            Move move = new Move();
           

            //Find out who goes first
            do
            {
                Console.Write("Who goes first?");
                Console.Write("\n");
                char firstPlayer = Console.ReadKey().KeyChar;

                if(firstPlayer == 'X')
                {
                    PlayerX.turn = true;
                    currentPlayer = PlayerX;
                }
                else
                {
                    PlayerO.turn = true;
                    currentPlayer = PlayerO;
                }
            }
            while (PlayerX.turn == false && PlayerO.turn == false);

            while(!Game.gameOver())
            {
                do
                {
                    Console.Write(currentPlayer.getIdentity(currentPlayer));
                    Console.Write("What is your move?");
                    Console.Write("\n");
                    move.X = (int)Console.ReadKey().KeyChar - 48;
                    move.Y = (int)Console.ReadKey().KeyChar - 48;

                }
                while (!currentPlayer.checkMove(move,currentPlayer));
            }



        } 
    }
}
