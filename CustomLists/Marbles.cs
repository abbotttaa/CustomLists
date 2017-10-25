using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class Marbles<T> : IEnumerable<T>
    {
        T[] marblesArray;
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
        public IEnumerator<T> IGetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return marblesArray[i];
            }
        }
        
       
        public void Add(T input)
        {
            IsArrayLargeEnough();
            marblesArray[count] = input;
            count++;
        }
        public bool Remove(T input)
        {
            int currentCount = count;
            FindInputToRemove(input);
            FixArrayRemove();
            return count != currentCount;
        }
        //public void ToString(T value)
        //{

        //}
        public override string ToString()
        {
            string newString = "";
            for(int i = 0; i < count; i++)
            {
                newString += marblesArray[i].ToString();
            }
            return newString;
        }
        public void FixArrayRemove()
        {
            T[] TempArray = new T[capacity];
            for (int i = 0; i <= (count-1); i++)
            {
                TempArray[i] = marblesArray[i];
            }
            marblesArray = TempArray;
        }
        public void IsArrayLargeEnough()
        {
            if(capacity <= (count/2))
            {
                FixArraySize();
            }
        }
        public void FindInputToRemove(T input)
        {

            for (int i = 0; i <= count; i++)
            {
                
                if (marblesArray[i].Equals(input))
                {                 
                    while (i < count)
                    {
                        marblesArray[i] = marblesArray[i + 1];
                        i++;
                    }
                    count--;
                    break;
                }            
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
        

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return marblesArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        } 
    }
}
