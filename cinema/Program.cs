namespace cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int student = 0;
            int standard = 0;
            int kid = 0;           

            while (true)
            {
               string movieName = Console.ReadLine();

                if (movieName == "Finish")
                {
                    break;
                }

                int availableSeats = int.Parse(Console.ReadLine());

                int totalTickets = 0;
               

                while (totalTickets < availableSeats)
                {
                    string typeTicket = Console.ReadLine();                    

                    if (typeTicket == "End")
                    {
                    break;
                    }

                    totalTickets++;

                    switch (typeTicket)
                    {
                        case "student": student++;  break;
                        case "kid": kid++; break;
                        case "standard": standard++;  break; 
                    }
                    
                }

                Console.WriteLine($"{movieName} - {(double)totalTickets / availableSeats * 100:f2}% full.");                
            }

            double absoluteTotal = student + standard + kid;

            Console.WriteLine($"Total tickets: {absoluteTotal}");
            Console.WriteLine($"{(double)student / absoluteTotal * 100:f2}% student tickets.");
            Console.WriteLine($"{(double)standard / absoluteTotal * 100:f2}% standard tickets.");
            Console.WriteLine($"{(double)kid / absoluteTotal * 100:f2}% kids tickets.");


        }
    }
}