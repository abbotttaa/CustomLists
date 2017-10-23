using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class Marbles<T>
    {
        T[] marblesArray;
        T[] passedInValueArray;
        T[] marblesArrayCombined;
        int capacity;
        int count;

        public Marbles()
        {
            this.capacity = 5;
        }
        public T this[int i]
        {
            get { return marblesArrayCombined[i]; }

            set { marblesArrayCombined[i] = value; }
        }
        
       
        public void Add(T input)
        {
            //CheckArrayCurrentSize();
            //CheckIncomingArraySize();
            IsArrayLargeEnough();
            CountArray();
            for (int i = 0; i >= count; i++)
            {
                marblesArrayCombined[i] = marblesArray[i];
                if(marblesArray[i+1] == null)
                {
                    marblesArrayCombined[i + 1] = input;
                }
            }
        }
        public void IsArrayLargeEnough()
        {
            if(capacity <= (count/2))
            {
                FixArraySize();
            }
        }
        public void FixArraySize()
        {
            capacity = (capacity * 2);
            T[] TempArray = new T[capacity];
            for(int i =0; i >= count; i++)
            {
                TempArray[i] = marblesArray[i];
            }
            marblesArray = TempArray;
        }
        public void CountArray()
        {
            for(int i = 0; i >=marblesArray.Length; i++)
            {
                count++;
            }
            count++;
        }


        //public void CheckArrayCurrentCount()
        //{
        //    int i = 0;

        //    T valueAtIndex = marblesArray[i];

        //    int lenghtOfCurrentArray = 0;

        //    for (i = 0; valueAtIndex == null; i++)
        //    {
        //        valueAtIndex = marblesArray[i];

        //        if (valueAtIndex != null)
        //        {
        //            lenghtOfCurrentArray++;
        //        }
        //    }
        //}
        //public void CheckIncomingArraySize()
        //{
        //    int i = 0;

        //    T valueAtIndex = passedInValueArray[i];

        //    int lenghtOfIncomingArray = 0;

        //    for (i = 0; valueAtIndex == null; i++)
        //    {
        //        valueAtIndex = marblesArray[i];

        //        if (valueAtIndex != null)
        //        {
        //            lenghtOfIncomingArray++;
        //        }
        //    }
        //}
        //public void EstablishNewArraySize()
        //{        
        //   capacity = lenghtOfCurrentArray + lenghtOfIncomingArray;
        //}
    }
}
