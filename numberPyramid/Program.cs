using System.Security;

namespace numberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int currentNumber = 1;

            for (int i = 0; i < number; i++)
            {
                

                for (int j = 0; j <= i; j++)
                {
                    if (currentNumber > number)
                    {
                        break; 
                    }
                    Console.Write(currentNumber + " ");
                    currentNumber++;
                }
                Console.WriteLine();
            }
        }
    }
}