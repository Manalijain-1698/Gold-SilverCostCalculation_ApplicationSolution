using System;

namespace Gold_SilverCostCalculation_Application
{

    class Program
    {

        static void Main(string[] args)
        {
            CostCalculation cc = new CostCalculation();
            Console.WriteLine("Enter Choice(Gold/Silver)");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "Gold":
                    Console.WriteLine("Enter grams of Gold Item");
                    double goldweight = Convert.ToDouble(Console.ReadLine());
                    cc.GoldCostcalculation(goldweight);
                    //Console.WriteLine("Total Amount for Gold of weight {0} is {1}", goldweight, totalamount);
                    break;
                case "Silver":
                    Console.WriteLine("Enter grams of Gold Item");
                    double silverweight = Convert.ToDouble(Console.ReadLine());
                    cc.SilverCostcalculation(silverweight);
                    //Console.WriteLine("Total Amount for Silver of weight {0} is {1}", silverweight, totalfare);
                    break;
                default:
                    Console.WriteLine("Invalid Choice!");
                    break;



                    //}

                    //cc.GoldCostcalculation(3);
                    //Console.WriteLine(amount);

            }
        }
    }
}

