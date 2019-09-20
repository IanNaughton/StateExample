using System;

namespace State
{
  public class PlayerUninitialized : IPlayerState
  {
    public void Start(IPlayer player, decimal money, decimal stock)
    {
      player.Money = money;
      player.Stock = stock;
      if (money > 0 && stock > 0)
      {
        player.SetState(new HasMoneyAndStock());
        Console.WriteLine($"Player initialized! You now have ${money} and {stock} shares! Yip!");
      }
      else if (money > 0 && stock == 0)
      {
        player.SetState(new HasMoneyAndNoStock());
        Console.WriteLine($"Player initialized! You now have ${money} and {stock} shares! Yip!");
      }
      else if (money == 0 && stock > 0)
      {
        player.SetState(new HasStockAndNoMoney());
        Console.WriteLine($"Player initialized! You now have ${money} and {stock} shares! Yip!");
      }
      else if (money == 0 && stock == 0)
      {
        player.SetState(new HasMoneyAndNoStock());
        Console.WriteLine($"Player initialized! You now have ${money} and {stock} shares! Yip!");
      }
      else
      {
        Console.WriteLine("Stop trying to break my example Wade! ;D");
      }
    }
    public void Buy(IPlayer player, decimal amount, decimal price)
    {
      Console.WriteLine("Hold on pup--this player hasn't been initialized yet! You can't buy stocks yet!");
    }

    public void Sell(IPlayer player, decimal amount, decimal price)
    {
      Console.WriteLine("Hold on pup--this player hasn't been initialized yet! You can't sell stocks yet!");
    }
  }
}