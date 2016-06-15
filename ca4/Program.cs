using System;

namespace ca4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[10];
            int[] arrayWithUnevenNumber = new int[10];
            int number;
            int i = 0; int j = 0;
            Random rnd = new Random();

            do
            {
                number = rnd.Next(20);
                if (Array.IndexOf(myArray, number) == -1)
                {
                    myArray[i] = number;
                    if (myArray[i] % 2 != 0)
                    {
                        arrayWithUnevenNumber[j] = myArray[i];
                        j++;
                    }
                    Console.WriteLine(myArray[i]);
                    i++;
                }
            } while (i < 10);

            Console.WriteLine("\nUneven numbers in array are: ");

            for (int a = 0; a < arrayWithUnevenNumber.Length; a++)
            {
                if (arrayWithUnevenNumber[a] != 0)
                {
                    Console.WriteLine(arrayWithUnevenNumber[a]);
                }

            }

            Console.ReadKey();
        }
    }
}

