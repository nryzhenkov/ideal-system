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

        public int mulArray { get; set; }

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

        public void InitRandom(int maxRand, int offset)
        {
            Random random = new Random();
            for (int i = 0; i < localArray.Length; i++)
                localArray[i] = random.Next(0, maxRand) - offset; 
        }
        // сортирует массив таким образом, что сначала располагаются все положительные элементы (0 положительное)
        public void Sort1()
        {
            if (!isNull)
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
        }
        // произведение элементов массива, расположенных между максимальным по модулю и минимальным по модулю элементами
        public void Mul1()
        {
            if (!isNull)
            {
                int max, min, maxInd, minInd, mulArr;
                max = min = Math.Abs(localArray[0]);
                maxInd = minInd = 0;
                mulArr = 1;
                for (int i = 1; i < localArray.Length; i++)
                {
                    if(Math.Abs(localArray[i]) > max)
                    {
                        max = Math.Abs(localArray[i]);
                        maxInd = i;
                        continue;
                    }
                    if(Math.Abs(localArray[i]) < min)
                    {
                        min = Math.Abs(localArray[i]);
                        minInd = i;
                        continue;
                    }
                }
                if(minInd == maxInd)
                {
                    mulArray = localArray[minInd];
                }
                if(minInd > maxInd)
                {
                    for (int i = maxInd; i <= minInd; i++)
                        mulArr *= localArray[i];
                    mulArray = mulArr;
                }
                if(minInd < maxInd)
                {
                    for (int i = minInd; i <= maxInd; i++)
                        mulArr *= localArray[i];
                    mulArray = mulArr;
                }

            }
            
        }
        // преобразует массив такм образом, что сначала идут 0
        public void Sort2()
        {
            if (!isNull)
            {
                int a = 0;
                int b = 0;
                for(int i = 0; i < localArray.Length; i++)
                {
                    if (localArray[i] == 0)
                    {
                        b = localArray[a];
                        localArray[a] = localArray[i];
                        localArray[i] = b;
                        a++;
                    }
                }
            }
        }
        // преобразует массив такм образом, что в коннце идут 0
        public void Sort3()
        {
            if (!isNull)
            {
                int a = localArray.Length - 1;
                int b = 0;
                for (int i = localArray.Length - 1; i >= 0; i--)
                {
                    if (localArray[i] == 0)
                    {
                        b = localArray[a];
                        localArray[a] = localArray[i];
                        localArray[i] = b;
                        a--;
                    }
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
