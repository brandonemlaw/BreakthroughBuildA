using System;

//Allows use of unmanaged code (Board dll)
using System.Runtime.InteropServices;

namespace GameCore
{




    public enum Square { X, O, S }; // Represents Player X Player Y and Spaces
    public class GameBoard
    {
        public Board board;
                
        public const short ROW = 8;
        public const short COL = 8;

        //Creating a Board of Enums 
        //private Enum[,] Board = new Enum[ROW, COL];

        /*public Enum[,] getBoard()
        {
            return Board;
        }*/

        //Returns a copy of the physical board
        public Board getBoard()
        {
            return board;
        }

        //Initializing a New Gameboard
        public void newGameBoard()
        {
            board = new Board();
            printGameBoard();
        }

        public void printGameBoard()
        {
            for (int i = 0; i < ROW; i++)
            {
                for (int j = 0; j < COL; j++)
                {
                    Console.Write(board.getPieceAt(i, j));
                    //Console.Write(Board[i, j]);
                    Console.Write(" ");// Temporary to see what is going on
                }
                Console.Write("\n"); // Temporary to see what is going on
            }
        }


        //Needs to be changed to actually find out if the game is over
        public bool gameOver()
        {
            return board.isGameOver();
         /*   for (int i = 0; i < ROW; i++)
            {
                for (int j = 0; j < COL; j++)
                {
                    if(i == ROW - 1)
                    {
                        if ((Square)Board[i, j] == Square.O)
                        {
                            return true;
                        }
                    }
                    if(i == 0)
                    {
                        if ((Square)Board[i, j] == Square.X)
                        {
                            return true;
                        }
                    }
                }
                 
            }
            return false;*/
        }

        //Returns the token as a Square object based on the board itself
        public Square getSquareToken(COORD coord)
        {
            char temp = board.getPieceAt(coord.X, coord.Y);
            if (temp == Config.XCHAR)
            {
                return Square.X;
            }
            else if (temp == Config.OCHAR)
            {
                return Square.O;
            }
            else
            {
                return Square.S;
            }
        }


        public void movePiece(char id,  Move move)
        {
            bool isXTurn = false;
            if (id == Config.XCHAR)
            {
                isXTurn = true;
            }
            board.makeMove(isXTurn, move.Begin.X, move.Begin.Y, move.End.X, move.End.Y);
            //Board[move.End.X, move.End.Y] = Board[move.Begin.X, move.Begin.Y];
            //Board[move.Begin.X, move.Begin.Y] = Square.S;
        }
    }

    

}
