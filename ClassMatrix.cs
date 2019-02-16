using System;

namespace MyMatrix
{
    public class ClassMatrix
    {
        public int[,] intMatrix  {  get; }
        int sizeX, sizeY;

        int SumColumn(int column)
        {
            int sum = 0;
            for (int j = 0; j < sizeX; j++)
                sum += intMatrix[j,column];
            return sum;
        }

        public void initMatrixRandom(int maxRand, int offset)
        {
            Random random = new Random();
            for (int i = 0; i < sizeX; i++)
                for (int j = 0; j < sizeY; j++)
                    intMatrix[i,j] = random.Next(0, maxRand) - offset;
        }
        // Находит количество элементов матрицы, если этот элемент больше суммы остальных элементов столбца
        public int CountElem()
        {
            int count = 0;
            int sum = 0;
            int middleSum = 0;
            for (int i = 0; i < sizeY; i++)
            {
                sum = SumColumn(i);
                for (int j = 0; j < sizeX; j++)
                {
                    middleSum = sum - intMatrix[j, i];
                    if (intMatrix[j, i] > middleSum)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public ClassMatrix(int x, int y)
        {
            if (x != 0 && y != 0)
            {
                intMatrix = new int[x, y];
                sizeX = x;
                sizeY = y;
            }
            else
                throw new Exception("размер не должен быть 0 0");
        }

    }
}
