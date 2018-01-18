using System;


namespace GameCore
{
    public enum Square { X, O, S }; // Represents Player X Player Y and Spaces
    public class GameBoard
    {
        public const short ROW = 8;
        public const short COL = 8;

        //Creating a Board of Enums 
        private Enum[,] Board = new Enum[ROW, COL];

        public Enum[,] getBoard()
        {
            return Board;
        }

        //Initializing a New Gameboard
        public void newGameBoard()
        {
            for(int i = 0; i < ROW; i++)
            {
                for (int j = 0; j < COL; j++)
                {
                    if (i <= 1)
                    {
                        Board[i, j] = Square.O;
                    }
                    else if (i >= 6)
                    {
                        Board[i, j] = Square.X;
                    }
                    else
                    {
                        Board[i, j] = Square.S;
                    }
                    Console.Write(Board[i, j]); // Temporary to see what is going on
                }
                Console.Write("\n"); // Temporary to see what is going on
            }
        }

        public void printGameBoard()
        {
            for (int i = 0; i < ROW; i++)
            {
                for (int j = 0; j < COL; j++)
                {
                    Console.Write(Board[i, j]); // Temporary to see what is going on
                }
                Console.Write("\n"); // Temporary to see what is going on
            }
        }


        //Needs to be changed to actually find out if the game is over
        public bool gameOver()
        {
            return false;
        }
        public Square getMove(COORD coord)
        {
            return (Square)Board[coord.X, coord.Y];
        }
        public void movePiece(Move move)
        {
            Board[move.End.X, move.End.Y] = Board[move.Begin.X, move.Begin.Y];
            Board[move.Begin.X, move.Begin.Y] = Square.S;
        }
    }

    

}
