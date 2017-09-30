using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            var Month = Console.ReadLine();
            var NightsCount = int.Parse(Console.ReadLine());
            double PriceStudio = 0;
            double PriceDouble = 0;
            double PriceSuite = 0;

            if ((NightsCount > 7) && (Month == "May"))
            {
                PriceStudio = ((NightsCount) * 50.00) - (5.00 * ((NightsCount) * 50.00) / 100.00);
                PriceDouble = (NightsCount * 65.00);
                PriceSuite = (NightsCount * 75.00);
                Console.WriteLine($"Studio: {PriceStudio:F2} lv.");
                Console.WriteLine($"Double: {PriceDouble:F2} lv.");
                Console.WriteLine($"Suite: {PriceSuite:F2} lv.");

            }
            else if ((NightsCount > 14) && (Month == "June" || Month == "September"))
            {
                PriceStudio = (NightsCount * 60.00);
                PriceDouble = (NightsCount * 72.00) - (10.00 * (NightsCount * 72.00) / 100.00);
                PriceSuite = (NightsCount * 82.00);
                Console.WriteLine($"Studio: {PriceStudio:F2} lv.");
                Console.WriteLine($"Double: {PriceDouble:F2} lv.");
                Console.WriteLine($"Suite: {PriceSuite:F2} lv.");
            }
            else if ((NightsCount > 14) && (Month == "July" || Month == "August" || Month == "December"))
            {
                PriceStudio = (NightsCount * 68.00);
                PriceDouble = (NightsCount * 77.00);
                PriceSuite = (NightsCount * 89.00) - (15.00 * (NightsCount * 89.00) / 100.00);
                Console.WriteLine($"Studio: {PriceStudio:F2} lv.");
                Console.WriteLine($"Double: {PriceDouble:F2} lv.");
                Console.WriteLine($"Suite: {PriceSuite:F2} lv.");
            }
            else if ((NightsCount > 7) && (Month == "September" || Month == "October"))
            {
                if (Month == "September")
                {
                    PriceStudio = ((NightsCount - 1) * 60.00);
                    PriceDouble = (NightsCount * 72.00);
                    PriceSuite = (NightsCount * 82.00);
                    Console.WriteLine($"Studio: {PriceStudio:F2} lv.");
                    Console.WriteLine($"Double: {PriceDouble:F2} lv.");
                    Console.WriteLine($"Suite: {PriceSuite:F2} lv.");
                }
                else
                {
                    PriceStudio = (((NightsCount - 1) * 68.00) -((5*(NightsCount-1)*68.00)/100));
                    PriceDouble = (NightsCount * 65.00);
                    PriceSuite = (NightsCount * 75.00);
                    Console.WriteLine($"Studio: {PriceStudio:F2} lv.");
                    Console.WriteLine($"Double: {PriceDouble:F2} lv.");
                    Console.WriteLine($"Suite: {PriceSuite:F2} lv.");
                }

            }
            else if (Month == "May" || Month == "October")
            {
                PriceStudio = (NightsCount * 50.00);
                PriceDouble = (NightsCount * 65.00);
                PriceSuite = (NightsCount * 75.00);
                Console.WriteLine($"Studio: {PriceStudio:F2} lv.");
                Console.WriteLine($"Double: {PriceDouble:F2} lv.");
                Console.WriteLine($"Suite: {PriceSuite:F2} lv.");
            }
            else if (Month == "June" || Month == "September")
            {
                PriceStudio = (NightsCount * 60.00);
                PriceDouble = (NightsCount * 72.00);
                PriceSuite = (NightsCount * 82.00);
                Console.WriteLine($"Studio: {PriceStudio:F2} lv.");
                Console.WriteLine($"Double: {PriceDouble:F2} lv.");
                Console.WriteLine($"Suite: {PriceSuite:F2} lv.");
            }
            else if (Month == "July" || Month == "August" || Month == "December")
            {
                PriceStudio = (NightsCount * 68.00);
                PriceDouble = (NightsCount * 77.00);
                PriceSuite = (NightsCount * 89.00);
                Console.WriteLine($"Studio: {PriceStudio:F2} lv.");
                Console.WriteLine($"Double: {PriceDouble:F2} lv.");
                Console.WriteLine($"Suite: {PriceSuite:F2} lv.");
            }

        }
    }
}
