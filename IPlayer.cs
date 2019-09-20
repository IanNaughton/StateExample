using System;

namespace State
{
  public interface IPlayer
  {
    decimal Stock { get; set; }
    decimal Money { get; set; }
    void SetState(IPlayerState state);
    void Start(decimal money, decimal stock);
    void Buy(decimal amount, decimal price);
    void Sell(decimal amount, decimal price);
  }
}