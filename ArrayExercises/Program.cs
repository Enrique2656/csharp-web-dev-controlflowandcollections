using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //1,2,3,4,5,
            int [] integerArray = { 1, 2, 3, 4, 5};
            Console.WriteLine(integerArray);
            foreach (int integer in integerArray)
            {
                if (integer % 2 == 1)
                {
                Console.WriteLine(integerArray);
                }
            }
        }
    }
}
