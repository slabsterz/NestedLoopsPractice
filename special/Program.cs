namespace special
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            

            for (int i = 1111; i < 9999; i++)
            {
                
                string numberString = i.ToString();

                bool isSpecial = true;

                for (int j = 0; j < numberString.Length; j++)
                {
                    int digit = int.Parse(numberString[j].ToString());

                    if (digit == 0 || number % digit != 0)
                    {
                        isSpecial = false;
                        break;
                    }
                }  

                if (isSpecial == true)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}