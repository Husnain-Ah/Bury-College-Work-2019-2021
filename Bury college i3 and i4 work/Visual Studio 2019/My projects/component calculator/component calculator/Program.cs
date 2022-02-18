using System;

namespace component_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string cpuComponent = "";
            Decimal cpuCost = Decimal.Parse("0.00");
            Decimal totalCost = Decimal.Parse("0.00");

            Console.WriteLine("Enter the name of the cpu");
            cpuComponent = Console.ReadLine();

            Console.WriteLine("Enter the cost of the cpu");
            cpuCost = Decimal.Parse(Console.ReadLine());

            totalCost = cpuCost;
            Console.WriteLine("Receipt");
            Console.WriteLine("CPU-" + cpuComponent + "=" + cpuCost.ToString());
            Console.WriteLine("");
            Console.WriteLine("TotalCost=" + totalCost.ToString());


            string MoboComponent = "";
            Decimal MoboCost = Decimal.Parse("0.00");
            Decimal totalMoboCost = Decimal.Parse("0.00");

            Console.WriteLine("Enter the name of the Motherboard");
            MoboComponent = Console.ReadLine();

            Console.WriteLine("Enter the cost of the Motherboard");
            MoboCost = Decimal.Parse(Console.ReadLine());

            totalMoboCost = MoboCost;
            Console.WriteLine("Receipt");
            Console.WriteLine("Motherboard-" + MoboComponent + "=" + MoboCost.ToString());
            Console.WriteLine("");
            Console.WriteLine("TotalCost=" + totalMoboCost.ToString());
        }
    }

}
