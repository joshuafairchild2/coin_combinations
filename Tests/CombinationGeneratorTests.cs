using System.Collections.Generic;
using Xunit;

namespace CoinCombinations
{
  public class CombinationGeneratorTests
  {
    [Fact]
    public void Generate_SortCoins_CountAllQuarters()
    {
      //arrange
      decimal change = 0.75m;
      List<string> sorted = new List<string>{"3 quarter(s)", "0 dime(s)", "0 nickel(s)", "0 pennies"};
      CombinationGenerator myGenerator = new CombinationGenerator();

      //act
      List<string> result = myGenerator.Generate(change);

      //assert
      Assert.Equal(sorted, result);
    }

    [Fact]
    public void Generate_SortCoins_CountAllDimes()
    {
      decimal change = 0.20m;
      List<string> sorted = new List<string>{"0 quarter(s)", "2 dime(s)", "0 nickel(s)", "0 pennies"};
      CombinationGenerator myGenerator = new CombinationGenerator();

      List<string> result = myGenerator.Generate(change);

      Assert.Equal(sorted, result);
    }

    [Fact]
    public void Generate_SortCoins_CountAllNickels()
    {
      decimal change = 0.30m;
      List<string> sorted = new List<string>{"1 quarter(s)", "0 dime(s)", "1 nickel(s)", "0 pennies"};
      CombinationGenerator myGenerator = new CombinationGenerator();

      List<string> result = myGenerator.Generate(change);

      Assert.Equal(sorted, result);
    }

    [Fact]
    public void Generate_SortCoins_CountAllPennies()
    {
      decimal change = 0.04m;
      List<string> sorted = new List<string>{"0 quarter(s)", "0 dime(s)", "0 nickel(s)", "4 pennies"};
      CombinationGenerator myGenerator = new CombinationGenerator();

      List<string> result = myGenerator.Generate(change);

      Assert.Equal(sorted, result);
    }
  }
}
