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
      List<string> sorted = new List<string>{"3 quarters"};
      CombinationGenerator myGenerator = new CombinationGenerator();

      //act
      List<string> result = myGenerator.Generate(change);

      //assert
      Assert.Equal(sorted, result);
    }
  }
}
