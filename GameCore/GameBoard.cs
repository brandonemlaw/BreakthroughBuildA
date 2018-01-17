using System;


namespace GameCore
{
    enum Sqaure { X, O, S }; // Represents Player X Player Y and Spaces
    public class GameBoard
    {
        public const short ROW = 8;
        public const short COL = 8;

        //Creating a Board of Enums 
        private Enum[,] Board = new Enum[ROW, COL];

        //Initializing a New Gameboard
        public void newGameBoard()
        {
            for(int i = 0; i < ROW; i++)
            {
                for (int j = 0; j < COL; j++)
                {
                    if (i <= 1)
                    {
                        Board[i, j] = Sqaure.X;
                    }
                    else if (i >= 6)
                    {
                        Board[i, j] = Sqaure.O;
                    }
                    else
                    {
                        Board[i, j] = Sqaure.S;
                    }
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
    }

    

}
