using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaximumNumber
{
    public class RefactorGenericMax<T> where T : IComparable  //generic class
    {
        public T firstValue, secondValue, thirdValue;
        public RefactorGenericMax(T firstValue, T secondValue, T thirdValue)  //constructor
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
        }
        public static T MaxValue(T firstValue, T secondValue, T thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0 ||
                firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0 ||
                firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                Console.WriteLine(firstValue + " Is Maximum");
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0 ||
                secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) > 0 ||
                secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) >= 0)
            {
                Console.WriteLine(secondValue + " Is Maximum");
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0 ||
                thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(secondValue) > 0 ||
                thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) >= 0)
            {
                Console.WriteLine(thirdValue + " Is Maximum");
                return thirdValue;
            }
            if (firstValue.CompareTo(secondValue) == 0 && firstValue.CompareTo(thirdValue) == 0 && secondValue.CompareTo(thirdValue) == 0)
            {
                Console.WriteLine("All The Three Number Are Same");
            }
            return default;
        }
        public T MaxMethod()
        {
            T max = RefactorGenericMax<T>.MaxValue(this.firstValue, this.secondValue, this.thirdValue);
            return max;
        }
    }
}
