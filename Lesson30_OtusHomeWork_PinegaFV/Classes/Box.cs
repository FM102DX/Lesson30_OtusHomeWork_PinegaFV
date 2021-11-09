using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson30_OtusHomeWork_PinegaFV
{
    public class Box : IMyCloneable<Box>, ICloneable
    {
        //некий кубический объект


        public int Width;
        public int Length;
        public int Height;

        public Box(int width, int length, int height)
        {
            Width = width;
            Height = height;
            Length = length;
        }

        public virtual Box MyClone()
        {
            return new Box(Width, Length, Height);
        }

        public virtual object Clone()
        {
            return MyClone();
        }
    }
}
