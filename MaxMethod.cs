using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaximumNumber
{
    public class MaxMethod
    {
        public static void Max(int[]arr)
        {
            Array.Sort(arr);
            int max = arr.Length - 1;
            Console.WriteLine("The Maximum integer is : " + arr[max]);
        }
    }
}
