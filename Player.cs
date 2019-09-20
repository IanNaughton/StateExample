using System;

namespace State
{

  public class Player : IPlayer
  {
    private IPlayerState _state;
    public decimal Money { get; set; }
    public decimal Stock { get; set; }

    public Player() 
    {
      _state = new PlayerUninitialized();      
    }

    public void SetState(IPlayerState state)
    {
      this._state = state;
    }

    public void Start(decimal money, decimal stock) {
      _state.Start(this, money, stock);
    }

    public void Buy(decimal amount, decimal price)
    {
      Console.WriteLine($"Trying to buy {amount} shares for ${price}! Bork!");
      _state.Buy(this, amount, price);
      Console.WriteLine($"You now have {amount} stocks, and ${Money} borkin' bucks!");
    }

    public void Sell(decimal amount, decimal price)
    {
      Console.WriteLine($"Trying to sell {amount} shares for ${price}! Bork!");
      _state.Sell(this, amount, price);
      Console.WriteLine($"You now have {amount} stocks, and ${Money} borkin' bucks!");
    }
  }
}