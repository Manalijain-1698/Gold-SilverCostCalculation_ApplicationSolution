using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gold_SilverCostCalculation_Application
{
    interface Gold
    {
        void GoldCostcalculation(double weight);
    }

    interface Silver
    {
        void SilverCostcalculation(double weight);

    }

    public class CostCalculation : Gold,Silver
    {
        public void GoldCostcalculation(double weight)
        {
            double currentgoldprice = 4900;
            double totalamount = weight * currentgoldprice;
            Console.WriteLine("Total Amount for Gold of weight {0} is {1}", weight, totalamount);
        }

        public void SilverCostcalculation(double weight)
        {
            double currentsilverprice = 75;
            double totalamount = weight * currentsilverprice;
            Console.WriteLine("Total Amount for Silver of weight {0} is {1}", weight, totalamount);
        }

        
    }
}
