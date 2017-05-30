using Nancy;
using System;
using System.Collections.Generic;

namespace CoinCombinations
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
      Get["/sorted"] = _ => {
        CombinationGenerator myGenerator = new CombinationGenerator();
        string userInput = Request.Query["userInput"];
        decimal inputAsDecimal = Decimal.Parse(userInput);
        List<string> coins = myGenerator.Generate(inputAsDecimal);
        return View["result.cshtml", coins];
      };
    }
  }
}
