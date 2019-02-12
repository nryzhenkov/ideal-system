using System;

namespace MyArray
{
    static public class FirstClass
    {
        
        static public int[] CreateArray(int size)
        {
            if (size > 0)
                return new int[size];
            return null;
        }

        static public void CreateArray(int size, out int[] array)
        {
            if (size > 0)
                array = new int[size];
            else
                array = null;
        }
    }

    public class SecondClass
    {
        public int[] localArray { get; set; }

        bool isNull;

        public SecondClass(int size)
        {
            if (size > 0)
            {
                localArray = new int[size];
                isNull = false;
            }
            else
            {
                localArray = null;
                isNull = true;
            }

        }

        public SecondClass()
        {
            localArray = null;
            isNull = true;
        }

        public void InitRandom()
        {
            Random random = new Random();
            for (int i = 0; i < localArray.Length; i++)
                localArray[i] = random.Next(0, 10) - 5;
        }

        public void Sort1()
        {
            int k = 0;
            int a = 0;
            for (int i = 0; i < localArray.Length - k; i++)
            {
                if (localArray[i] >= 0)
                {
                    continue;
                }
                if (localArray[i] < 0)
                {
                    for (int j = i; j < localArray.Length - k - 1; j++)
                    {
                        a = localArray[j];
                        localArray[j] = localArray[j + 1];
                        localArray[j + 1] = a;
                    }
                    k++;
                    i--;
                }

            }
        }

        public bool CreateArray(int size)
        {
            if (isNull)
            {
                localArray = new int[size];
                return true;
            }

            return false;
        }
    }
}
