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
            Player currentPlayer = null;
            COORD coord = new COORD();
            Move move = new Move();

            FirstPlayer(PlayerX, PlayerO, ref currentPlayer);
            beginGame(ref currentPlayer, ref Game, ref move);



        }

        private static void FirstPlayer(Player PlayerX, Player PlayerO, ref Player currentPlayer)
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
        }

        private static void beginGame(ref Player currentPlayer, ref GameBoard Game,
                                      ref Move move)
        { 
            while (!Game.gameOver())
            {
                do
                {
                    Console.Write(currentPlayer.getIdentity(currentPlayer));
                    Console.Write("What COORD do you want to move?");
                    Console.Write("\n");
                    move.Begin.X = (int)Console.ReadKey().KeyChar - 49;
                    move.Begin.Y = (int)Console.ReadKey().KeyChar - 49;

                }
                while (!checkCOORD(currentPlayer, Game, move));

                do
                {
                    Console.Write(currentPlayer.getIdentity(currentPlayer));
                    Console.Write("Where do you want to move ");
                    Console.Write(move.Begin.X+1);
                    Console.Write(move.Begin.Y+1);
                    Console.Write("?\n");
                    move.End.X = (int)Console.ReadKey().KeyChar - 49;
                    move.End.Y = (int)Console.ReadKey().KeyChar - 49;
                }
                while (!checkMove(currentPlayer, Game, move));
           
            }

        }
        private static bool checkCOORD(Player currentPlayer, GameBoard game, Move move)
        {
            if (currentPlayer.getIdentity(currentPlayer) == (char)identity.X)
            {
                if (game.getMove(move.Begin) != Square.X)
                {

                    Console.Write("Invalid COORD... Try Again");
                    return false;
                    //Greater than thye loaction your on
                }
                return true;
            }

            if(currentPlayer.getIdentity(currentPlayer) == (char)identity.O)
            {
                if (game.getMove(move.Begin) != Square.O)
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
            if (currentPlayer.getIdentity(currentPlayer) == (char)identity.X)
            {
                if (game.getMove(move.End) == Square.X)
                {

                    Console.Write("Invalid move... Try Again");
                    return false;
                    //Greater than the loaction your on
                }

                // Check for Up one
                if (
                        move.Begin.X - 1 == move.End.X &&
                       //Check Left,Center,Right after up one)
                       (
                        move.Begin.Y - 1 == move.End.Y      || 
                        move.Begin.Y     == move.End.Y      || 
                        move.Begin.Y + 1 == move.End.Y
                       )                                    &&
                       //Check Bounds For X
                       ((move.End.X <= 7 && move.End.X >= 0) &&
                       //Check Bounds For Y
                       (move.End.Y <= 7 && move.End.Y >= 0))
                   )
                {
                    return true;
                }
              
            }

            return true;

            if (currentPlayer.getIdentity(currentPlayer) == (char)identity.O)
            {
                if (game.getMove(move.End) != Square.O)
                {

                    Console.Write("Invalid COORD... Try Again");
                    return false;
                    //Greater than thye loaction your on
                }
                return true;
            }
           
        }
    }
}
