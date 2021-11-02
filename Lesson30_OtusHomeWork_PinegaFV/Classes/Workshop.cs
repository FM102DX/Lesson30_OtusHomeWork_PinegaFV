using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson30_OtusHomeWork_PinegaFV
{
    public class Workshop : Room, IMyCloneable<Room>, ICloneable
    {
        //мастерская, разновидность комнаты

        public string ShieldTitle;

        public Workshop(string shieldTitle, int numberOfWindows, int numberOfDoors, int width, int length, int height) : base(numberOfWindows, numberOfDoors, width, length, height)
        {
            ShieldTitle = shieldTitle;
        }

        public new Workshop MyClone()
        {
            return new Workshop(ShieldTitle, NumberOfWindows, NumberOfDoors, Width, Length, Height);
        }

        public override string ToString()
        {
            return $"{ShieldTitle},двери:{NumberOfDoors}, окна:{NumberOfWindows}";
        }
        public object Clone()
        {
            return MyClone();
        }
    }
}
