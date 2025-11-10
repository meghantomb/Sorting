namespace ConsoleApp1
{
    internal class Program
    {
        static void StudentBubbleSort(int[] anArray)
        {
            //loop for as many times as the length in case one needs to move all the way from the back to the front
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
                //if we went through the whole list once without swapping anything its done
                if (!sorting) { break; }
            }
        }
        static void Main(string[] args)
        {
            int[] array1 = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
            int[] array2 = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };

            Console.WriteLine("Array1 before any sorting: ");
            //not sure if we learned for each loops but i love for each loops
            foreach(int num in array1)
            {
                Console.WriteLine(num);
            }
            StudentBubbleSort(array1);
            Console.WriteLine("Array1 after bubble sort: ");
             foreach (int num in array1)
             {
                 Console.WriteLine(num);
             }
             Console.WriteLine("Array2 before any sorting: ");
            foreach (int num in array2)
            {
                Console.WriteLine(num);
            }
            Array.Sort(array2);
            Console.WriteLine("Array2 after built in sort: ");
            foreach (int num in array1)
            {
                Console.WriteLine(num);
            }
        }
    }
}
