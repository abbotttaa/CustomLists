﻿using System;
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
            this.capacity = 10;
            this.marblesArray = new T[capacity];
        }
        public int Count
        {
            get
            {
                return count;
            }
        }
        public T this[int i]
        {
            get { return marblesArray[i]; }

            set { marblesArray[i] = value; }
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
        public static Marbles<T> operator + (Marbles<T> list1, Marbles<T> list2)
        {
            Marbles<T> marblesArray = new Marbles<T>();
            
            
            for(int i = 0; i < list1.Count; i++)
            {
                marblesArray.Add(list1[i]);
            }
            for(int i = 0; i < list2.Count; i++)
            {
                marblesArray.Add(list2[i]);
            }
            return marblesArray;
        }
        public static Marbles<T> operator -(Marbles<T> list1, Marbles<T> list2)
        {
            Marbles<T> marblesArray = new Marbles<T>();
            Marbles<T> tempArray = new Marbles<T>();
            Marbles<T> tempList1 = new Marbles<T>();
            Marbles<T> tempList2 = new Marbles<T>();


            for (int i = 0; i < list1.Count; i++)
            {
                marblesArray.Add(list1[i]);
            }
            for (int i = 0; i < list2.Count; i++)
            {
                marblesArray.Add(list2[i]);
            }

            for (int i = 0; i < list1.Count; i++)
            {
                var valueToCheck1 = list1[i];
                for (int j = 0; j < list2.Count; j++)
                {
                    if (list1[i].Equals(list2[j]))
                    {
                        marblesArray.Remove(list1[i]);
                        break;
                    }

                }
            }
            return marblesArray;
                

                //    for (int i = 0; i < tempList1.Count; i++)
                //    {
                //        for(int j = 0; j < tempList2.Count; i++)
                //        {
                //            bool result = list2.Remove(list1[i]);
                //            if(result == false)
                //            {
                //                tempArray.Add(list1[i]);
                //            }
                //        }

                //    }


                //    for (int i = 0; i < tempList2.Count; i++)
                //    {
                //        for(int j = 0; j < tempList1.Count; i++)
                //        {
                //            bool result = list1.Remove(list2[i]);
                //            if(result == false)
                //            {
                //                tempArray.Add(list2[i]);
                //            }
                //        }
                //    }


                //    return marblesArray;
        }
        public void IsArrayLargeEnough()
        {
            if(capacity <= (count*2))
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
            for(int i =0; i <= count; i++)
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
