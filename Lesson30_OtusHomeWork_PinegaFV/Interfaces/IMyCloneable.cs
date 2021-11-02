using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson30_OtusHomeWork_PinegaFV
{
   public interface IMyCloneable<T>:ICloneable
    {
        public T MyClone();
    }
}
