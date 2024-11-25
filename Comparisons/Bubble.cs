using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparisons
{
    public class Bubble
    {
        public delegate bool Comparison(object obj1, object obj2);

        public static void Sort(object[] array, Comparison comparison)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (!comparison(array[j], array[j + 1]))
                    {
                        
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
}

