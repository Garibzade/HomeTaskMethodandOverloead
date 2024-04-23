using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskMethodMethodoverload.MinValue
{
    internal static class Class1
    {
        public static int MinValue(int[] arr)
        {

            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {

                if (arr[i] < min)
                {
                    min = arr[i];

                }

            }

            return min;
        }
    }
}
