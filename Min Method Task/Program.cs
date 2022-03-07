using System;

namespace Min_Method_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 22, 33, 42345, 543, 65, 7, -34, 0, -873 };
            Min(array);
            Console.WriteLine(Min(array));
        }

        static int Min(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }
    }
}
