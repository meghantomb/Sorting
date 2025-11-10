namespace ConsoleApp1
{
    internal class Program
    {
        static void StudentBubbleSort(int[] anArray)
        {
            for (int i = 0; i < anArray.Length; i++)
            {
                bool sorting = false;
                for (int j = 0; j < anArray.Length - 1; j++)
                {
                    if (anArray[j] > anArray[j + 1])
                    {
                        sorting = true;
                        (anArray[j], anArray[j + 1]) = (anArray[j + 1], anArray[j]);
                    }
                }
                if (!sorting) { break; }
            }
        static void Main(string[] args)
        {
            int[] array1 = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
            int[] array2 = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
        }
    }
}
