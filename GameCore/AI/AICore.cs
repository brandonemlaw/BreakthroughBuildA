using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI
{
    public class AICore
    {
        //private board[]

        public GameCore.Move getNextMove(GameCore.Board board)
        {
            //Build the result
            GameCore.Move result = new GameCore.Move();
            


            //return the result
            return result;
        }

        private struct cons
        {
            public const double Penetration = 1;
        }


        //Evaluate returns a positive number if white is favored, and
        //negative if black is favored.
        public static double evaluate1(bool whitesTurn, GameCore.Board board)
        {
            double result = 0;


            //Penetration
            result += cons.Penetration * EvaluationUtils.evalWPenetration(ref board);
            result += cons.Penetration * EvaluationUtils.evalBPenetration(ref board);

            
            return result;
        }


        /*private generatePossibleMoves()
        {

        }*/
    }
}
