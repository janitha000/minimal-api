using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minimal_api.Core.Common
{
    public class GenericService<T>
    {
        private static object[] Sort<T>(object[] inputArr)
        {
            Array.Sort(inputArr);
            return inputArr;

        }

        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;

            //int a = 5;
            //int b = 12;
            //Swap<int>(ref a, ref b);
        }

    }
}
