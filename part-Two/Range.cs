using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

/*
create a generic Range<T> class that represents a range of values from a minimum value to a maximum value. 
Requirements:
Create a generic class named Range<T> where T represents the type of values.
Implement a method Length() that returns the length of the range (the difference between the maximum and minimum values).
Note: You can assume that the type T used in the Range<T> class implements the IComparable<T> interface to allow for comparisons.

 */
namespace Gemric_01.part_Two
{
    internal class MyRange<T>  where T : struct, IComparable<T>
    {
       static  public T minimum { get; set; }
       static  public T maximum { get; set; }

        public MyRange(T _min,T _max)
        { 
            if(_min.CompareTo(_max)  >0)
            { 
                Console.WriteLine("min should Be Less than Max");
                return;
            }
            minimum = _min; 
            maximum = _max;
        }

        public  int ArrLength(T[] Arr)
        {
           
            if (Arr is null || Arr.Length == 0) return 0;
            // I search on Microsoft Documtation then Found dynamic 
            else return(dynamic)maximum-(dynamic)(minimum);
        }

        public  bool IsInRange(T value)
        {
            if(value.CompareTo(minimum) >= 0 && value.CompareTo(maximum) <= 0) return true;
            return false;
        } 
    } 
}
