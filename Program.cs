using System;

namespace New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeFlolers = Console.ReadLine();  
            int numFlolers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double totalFlolersPrice = 0;
            

            switch (typeFlolers)
            {
                case "Roses":
                    totalFlolersPrice =  5; break;
                case "Dahlias":
                    totalFlolersPrice =  3.80; break;
                case "Tulips":
                    totalFlolersPrice =  2.80; break;
                case "Narcissus":
                    totalFlolersPrice =  3; break;
                case "Gladiolus":
                    totalFlolersPrice = 2.50; break;
            }
            double total = totalFlolersPrice * numFlolers;

            if (typeFlolers == "Roses" && numFlolers > 80)
            {
                total *= 0.9;
            }
            else if (typeFlolers == "Dahlias" && numFlolers > 90)
            {
                total *= 0.85;
            }
            else if (typeFlolers == "Tulips" && numFlolers > 80)
            {
                total *= 0.85;
            }
            else if (typeFlolers == "Narcissus" && numFlolers < 120)
            {
                total *= 1.15;
            }
            else if (typeFlolers == "Gladiolus" && numFlolers < 80)
            {
                total *= 1.20;
            }

            if (budget >= total)
            {
                Console.WriteLine($"Hey, you have a great garden with {numFlolers} {typeFlolers} and {budget - total:f2} leva left."); 
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {total - budget:f2} leva more.");
            }
        }
    }
}
