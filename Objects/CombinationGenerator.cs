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
        int dimes = 0;
        int nickels = 0;

        while(change >= 0.25m)
        {
          change -= 0.25m;
          quarters++;
        }
        while(change >= 0.10m)
        {
          change -= 0.10m;
          dimes++;
        }
        while(change >= 0.05m)
        {
          change -= 0.05m;
          nickels++;
        }

        coins.Add($"{quarters} quarter(s)");
        coins.Add($"{dimes} dime(s)");
        coins.Add($"{nickels} nickel(s)");
      }

      return coins;
    }
  }
}
