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

        //Find out who the first player is going to be
        private static void FirstPlayer(Player PlayerX, Player PlayerO, ref Player currentPlayer)
        {
            //Player X Always Goes First
            PlayerX.turn = true;
            currentPlayer = PlayerX;
        
        }
        //Begin the game
        private static void beginGame(ref Player currentPlayer, ref GameBoard Game,
                                      ref Move move)
        { 
            while (!Game.gameOver())
            {
                Console.Write(currentPlayer.getIdentity());
                do
                {
                    move.getBeginMove();
                }
                while (!checkCOORD(currentPlayer, Game, move));

                do
                {
                    move.getEndMove();
                }
                while (!checkMove(currentPlayer, Game, move));

                Game.movePiece(currentPlayer.getIdentity(), move);
                Game.printGameBoard();

                if(currentPlayer.getIdentity() == (char)identity.X)
                {
                    currentPlayer.setPlayer(identity.O);
                }
                else
                {
                    currentPlayer.setPlayer(identity.X);
                }
            }
        }
        private static bool checkCOORD(Player currentPlayer, GameBoard game, Move move)
        {
            if (currentPlayer.getIdentity() == Config.XCHAR)
            {
                if (game.getSquareToken(move.Begin) != Square.X)
                {

                    Console.Write("Invalid COORD... Try Again");
                    return false;
                    //Greater than thye loaction your on
                }
                return true;
            }

            if(currentPlayer.getIdentity() == Config.OCHAR)
            {
                if (game.getSquareToken(move.Begin) != Square.O)
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
            if (currentPlayer.getIdentity() == Config.XCHAR)
            {
                if (game.getSquareToken(move.End) == Square.X)
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
                       (move.Begin.Y     == move.End.Y  && game.getSquareToken(move.End) != Square.O )   || 
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
                else
                {
                    return false;
                }
              
            }

            if (currentPlayer.getIdentity() == Config.OCHAR)
            {
                if (game.getSquareToken(move.End) == Square.O)
                {

                    Console.Write("Invalid move... Try Again");
                    return false;
                    //Greater than the loaction your on
                }

                // Check for Down one
                if (
                        move.Begin.X + 1 == move.End.X &&
                       //Check Left,Center,Right after up one)
                       (
                        move.Begin.Y - 1 == move.End.Y ||
                       (move.Begin.Y == move.End.Y && game.getSquareToken(move.End) != Square.X )||
                        move.Begin.Y + 1 == move.End.Y
                       ) &&
                       //Check Bounds For X
                       ((move.End.X <= 7 && move.End.X >= 0) &&
                       //Check Bounds For Y
                       (move.End.Y <= 7 && move.End.Y >= 0))
                   )
                {
                    return true;
                }
                else
                {
                    return false;
                }
              
            }
                return false;
        }

    }
}
