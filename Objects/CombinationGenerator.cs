using System.Collections.Generic;

namespace CoinCombinations
{
  public class CombinationGenerator
  {
    public List<string> Generate(decimal changeToSort)
    {
      List<string> coins = new List<string>{};
      decimal change = changeToSort;

      if (change > 0)
      {
        int quarters = 0;

        while(change >= 0.25m)
        {
          change -= 0.25m;
          quarters++;
        }

        coins.Add($"{quarters} quarters");
      }

      return coins;
    }
  }
}
