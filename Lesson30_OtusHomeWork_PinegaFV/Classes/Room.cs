using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson30_OtusHomeWork_PinegaFV
{
    public class Room : Box, IMyCloneable<Room>, ICloneable
    {
        //комната, унаследована от куба

        public int NumberOfWindows;
        public int NumberOfDoors;

        public Room(int numberOfWindows, int numberOfDoors, int width, int length, int height) : base (width, length, height)
        {
            NumberOfWindows = numberOfWindows;
            NumberOfDoors = numberOfDoors;
        }

        public override Room MyClone()
        {
            return new Room(NumberOfWindows, NumberOfDoors, Width, Length, Height);
        }

        public override object Clone()
        {
            return MyClone();
        }

    }
}
