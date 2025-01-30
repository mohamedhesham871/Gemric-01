using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemric_01.Part_one
{
    internal class MyOwnClass<T> where T : IComparable<T>
    {
        static public void Swap( ref T x, ref T Y)
        {
            T tmep = x;
            x = Y;
            Y = tmep;
        }
        //Time Complexity of Bubble Sort in Worth case BigO(n^2) there this is more Butter  Algorithms take Big O(n Log n)
        //But i can impore preformance by haveing bool cheak is there is no change will stop 
        static public void BubbleSort(T[] Arr)
        {
            bool IsSorted=false;
            for (int i = 0; i < Arr.Length; i++) {
                IsSorted = false;
                for (int j = 0; j < Arr.Length - 1; j++)
                {
                    if (Arr[j].CompareTo(Arr[j + 1]) == 1)
                    {
                        Swap(ref Arr[j], ref Arr[j + 1]);
                        IsSorted = true;
                    }
                }
               if (!IsSorted) return;
                            
            }
        }
           
    }

}
