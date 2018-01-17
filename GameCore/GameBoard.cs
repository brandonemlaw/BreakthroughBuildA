using System;

//System.Collections.Generic.List<int>

//All of this class when need revised. 
//didWin() will certainly need to be changed to reult in true or false. 


namespace GameCore
{
    enum Sqaure { X, O, S };
    public class GameBoard
    {
        public const short ROW = 8;
        public const short COL = 8;
        private Enum[,] Board = new Enum[ROW, COL];
        public void initBoard()
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
                    Console.Write(Board[i, j]);
                }
                Console.Write("\n");
            }
        }
    }

    

}
