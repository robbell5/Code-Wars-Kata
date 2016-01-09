using System.Collections.Generic;
using System.Linq;

namespace Code_Wars_Kata.FilterCoffee
{
    public class FilterCoffee
    {
        public static int[] Search(int budget, int[] prices)
        {
            List<int> affordablePrices = prices.Where(price => price <= budget).ToList();
            affordablePrices.Sort();
            return affordablePrices.ToArray();
        }
    }
}
