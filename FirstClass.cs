
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
}
