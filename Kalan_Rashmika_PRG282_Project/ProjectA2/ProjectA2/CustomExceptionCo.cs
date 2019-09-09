using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA2
{
    class CustomExceptionCo:Exception
    {
        public CustomExceptionCo()
            :base("A value/values are out of the acceptable range.")
        {

        }

        public static void Check(int x1, int y1)
        {
            if ((x1<579)||(x1>1009)||(y1<12)||(y1>472))
            {
                throw new CustomExceptionCo();
            }
        }
    }
}
