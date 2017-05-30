using Nancy;

namespace CoinCombinations
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => "hello world";
    }
  }
}
