
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
        int[] localArray;

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
