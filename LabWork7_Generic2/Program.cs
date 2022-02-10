using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork7_Generic2
{
    class Program
    {
        public static void Main()
        {
            var arrayInt = new int[] { 1, 5, 3 };
            var arrayDouble = new double[] { 1.4, 5, 4, 3.3 };
            var arrayString = new string[] { "fisrt", "third", "second" };

            Console.WriteLine(IsSort(arrayInt));
            Console.WriteLine(IsSort(arrayDouble));
            Console.WriteLine(IsSort(arrayString));
            Console.WriteLine(IsSort(arrayInt.OrderBy(a => a).ToArray()));

            Console.ReadLine();
        }

        private static bool IsSort<T>(T[] array)
          where T : IEquatable<T>, IComparable<T>, IComparable
        {
            var arrayOrder = array.OrderBy(a => a).ToArray();

            for (var i = 0; i < array.Length; i++)
            {
                if ((dynamic)array[i] != (dynamic)arrayOrder[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
