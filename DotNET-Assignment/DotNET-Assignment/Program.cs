namespace DotNET_Assignment
{
    using DotNET_Assignment.Models;
    using System;

    class Program
    {
        static void Main()
        {
            TestingData();
        }

        private static void TestingData()
        {
            Owner owner = new Owner("John", "Smith");

            Console.WriteLine("Bronze Card test:");
            var bronzeCard = new BronzeCard(0, owner);
            PayDesk.PrintInformation(bronzeCard, 150);

            Console.WriteLine("Silver Card test:");
            var silverCard = new SilverCard(600, owner);
            PayDesk.PrintInformation(silverCard, 850);

            Console.WriteLine("Gold Card test:");
            var goldCard = new GoldCard(1500, owner);
            PayDesk.PrintInformation(goldCard, 1300);
        }
    }
}