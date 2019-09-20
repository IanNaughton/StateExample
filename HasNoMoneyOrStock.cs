using System;

namespace State
{
  public class HasNoMoney : IPlayerState
  {
    public void Start(IPlayer player, decimal money, decimal stock)
    {
      Console.WriteLine("Yip! This pup has already been initialized!");
    }
    
    public void Buy(IPlayer player, decimal amount, decimal price)
    {
      Console.WriteLine("You don't have any money! No treats for you! :'(");
    }

    public void Sell(IPlayer player, decimal amount, decimal price)
    {
      Console.WriteLine("Silly pup! You've got no stocks to sell!");
    }
  }
}