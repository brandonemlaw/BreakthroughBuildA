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
           

            //Find out who goes first
            do
            {
                Console.Write("Who goes first?");
                Console.Write("\n");
                char firstPlayer = Console.ReadKey().KeyChar;

                if(firstPlayer == 'X')
                {
                    PlayerX.turn = true;
                }
                else
                {
                    PlayerO.turn = true;
                }
            }
            while (PlayerX.turn == false && PlayerO.turn == false);
        } 
    }
}
