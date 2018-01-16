using System;
namespace GameCore
{
    public class Coordinate
    {

        struct Coord
        {
            private int x;
            private int y;
        }
 
        public Coordinate()
        {
            var MyCoord = new Coord();
        }


        public Coord getCoordinate(Coord MyCoord)
        {
            return MyCoord;
            //This is not correct and will need to be changed come time for implementation.
        }
    }
}
