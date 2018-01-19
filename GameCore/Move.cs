using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore
{

   
    public class Move
    {
       public int row;
       public char col;
       public COORD Begin = new COORD();
       public COORD End = new COORD();

        public void convertMove(COORD coord)
        {
            coord.X = col - 58;
            coord.Y = row - 1;
        }
    }



  
}
