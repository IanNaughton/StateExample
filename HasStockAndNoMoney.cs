using System;

namespace State
{
  public class HasStockAndNoMoney : IPlayerState
  {
    public void Start(IPlayer player, decimal money, decimal stock)
    {
      Console.WriteLine("Yip! This pup has already been initialized!");
    }

    public void Buy(IPlayer player, decimal amount, decimal price)
    {
      Console.WriteLine("You've got no borkin' bucks pup!");
    }

    public void Sell(IPlayer player, decimal amount, decimal price)
    {
      var total = (amount * price);

      if (player.Stock > total)
      {
        player.Money = player.Money + total;
        player.Stock = player.Stock - amount;
        Console.WriteLine($"Sold {amount} shares, for ${price}");
        player.SetState(new HasMoneyAndStock());
      }
      else if (player.Stock == total)
      {
        player.Money = player.Money + total;
        player.Stock = player.Stock - amount;
        Console.WriteLine($"Sold {amount} shares, for ${price}");
        player.SetState(new HasMoneyAndNoStock());
      }
      else
      {
        Console.WriteLine("Sad day doggo--you don't have enough stocks!");
      }
    }
  }
}