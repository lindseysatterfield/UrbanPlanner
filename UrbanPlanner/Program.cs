using System;

namespace UrbanPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEigth = new Building("512 8th Avenue");
            FiveOneTwoEigth.Width = 500.5;
            FiveOneTwoEigth.Depth = 1000.5;
            FiveOneTwoEigth.Stories = 20;
            FiveOneTwoEigth.Construct();
            FiveOneTwoEigth.Purchase("Lindsey Satterfield");
            Console.WriteLine();

            Building BatmanBuilding = new Building("333 Commerce St");
            BatmanBuilding.Width = 800.6;
            BatmanBuilding.Depth = 300.4;
            BatmanBuilding.Stories = 33;
            BatmanBuilding.Construct();
            BatmanBuilding.Purchase("Batman");
            Console.WriteLine();

            Building EmpireStateBuilding = new Building("350 Fifth Avenue");
            EmpireStateBuilding.Width = 700;
            EmpireStateBuilding.Depth = 1250;
            EmpireStateBuilding.Stories = 102;
            EmpireStateBuilding.Construct();
            EmpireStateBuilding.Purchase("Some New Yorker");
            Console.WriteLine();

            Building BridgestoneArena = new Building("501 Broadway");
            BridgestoneArena.Width = 900;
            BridgestoneArena.Depth = 478;
            BridgestoneArena.Stories = 7;
            BridgestoneArena.Construct();
            BridgestoneArena.Purchase("Nashville Predators");
            Console.WriteLine();
        }
    }
}
