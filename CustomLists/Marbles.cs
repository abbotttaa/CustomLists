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
        //T[] marblesArrayCombined;
        int capacity;
        int count;

        public Marbles()
        {
            this.capacity = 5;
            this.marblesArray = new T[capacity];
        }
        public T this[int i]
        {
            get { return marblesArray[i]; }

            set { marblesArray[i] = value; }
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
                yield return marblesArray[i];
        }
        
       
        public void Add(T input)
        {
            IsArrayLargeEnough();
            marblesArray[count] = input;
            count++;
        }
        public void Remove(T input)
        {

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
            for(int i = 0; i <=marblesArray.Length; i++)
            {
                count++;
            }
        }
    }
}
