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
            Piece piece = new Piece();
           

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
                    Console.Write("What Piece do you want to move?");
                    Console.Write("\n");
                    piece.X = (int)Console.ReadKey().KeyChar - 48;
                    piece.Y = (int)Console.ReadKey().KeyChar - 48;

                }
                while (!checkPiece(piece,currentPlayer, Game));
            }



        }

        private static bool checkPiece(Piece piece, Player currentPlayer, GameBoard game)
        {
            if (currentPlayer.getIdentity(currentPlayer) == (char)identity.X)
            {
                if (game.getPiece(piece) != Square.X)
                {

                    Console.Write("Invalid Piece... Try Again");
                    return false;
                    //Greater than thye loaction your on
                }
                return true;
            }

            if(currentPlayer.getIdentity(currentPlayer) == (char)identity.O)
            {
                if (game.getPiece(piece) != Square.O)
                {

                    Console.Write("Invalid Piece... Try Again");
                    return false;
                    //Greater than thye loaction your on
                }
                return true;
            }
            else
            {
                Console.Write("Invalid Piece... Try Again");
                return false;
            }
        }
    }
}
