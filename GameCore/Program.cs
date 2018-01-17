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
            COORD coord = new COORD();
            Move move = new Move();




        }

        private static void FirstPlayer(Player PlayerX,       Player PlayerO, 
                                        Player currentPlayer, GameBoard Game,
                                        Move move)
        {
            //Find out who goes first
            do
            {
                Console.Write("Who goes first?");
                Console.Write("\n");
                char firstPlayer = Console.ReadKey().KeyChar;

                if (firstPlayer == 'X')
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

            while (!Game.gameOver())
            {
                do
                {
                    Console.Write(currentPlayer.getIdentity(currentPlayer));
                    Console.Write("What COORD do you want to move?");
                    Console.Write("\n");
                    move.Begin.X = (int)Console.ReadKey().KeyChar - 48;
                    move.Begin.Y = (int)Console.ReadKey().KeyChar - 48;

                }
                while (!checkCOORD(currentPlayer, Game, move));

                do
                {
                    Console.Write(currentPlayer.getIdentity(currentPlayer));
                    Console.Write("Where do you want to move ");
                    Console.Write(move.Begin.X);
                    Console.Write(move.Begin.Y);
                    Console.Write("?\n");
                    move.End.X = (int)Console.ReadKey().KeyChar - 48;
                    move.End.Y = (int)Console.ReadKey().KeyChar - 48;
                }
                while (!checkMove(currentPlayer, Game, move));
            }

        }
        private static bool checkCOORD(Player currentPlayer, GameBoard game, Move move)
        {
            if (currentPlayer.getIdentity(currentPlayer) == (char)identity.X)
            {
                if (game.getMove(move) != Square.X)
                {

                    Console.Write("Invalid COORD... Try Again");
                    return false;
                    //Greater than thye loaction your on
                }
                return true;
            }

            if(currentPlayer.getIdentity(currentPlayer) == (char)identity.O)
            {
                if (game.getMove(move) != Square.O)
                {

                    Console.Write("Invalid COORD... Try Again");
                    return false;
                    //Greater than thye loaction your on
                }
                return true;
            }
            else
            {
                Console.Write("Invalid COORD... Try Again");
                return false;
            }
        }

        private static bool checkMove(Player currentPlayer, GameBoard game, Move move)
        {

            return false;
        }
    }
}
