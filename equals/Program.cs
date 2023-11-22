namespace equals
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int firstNumber = int.Parse(Console.ReadLine());
           int secondNumber = int.Parse(Console.ReadLine()); 
            
           for (int i = firstNumber; i <= secondNumber; i++)
            {
                int oddSum = 0;
                int evenSum = 0;

                string numberString = i.ToString();

                for (int j = 0; j < numberString.Length; j++)
                {
                    int digit = int.Parse(numberString[j].ToString());

                    if (j % 2 == 0)
                    {
                        oddSum += digit;
                    }
                    else
                    {
                        evenSum += digit;
                    }
                }

                if (oddSum == evenSum)
                {
                    Console.Write(i + " ");
                }

            }


        }
    }
}