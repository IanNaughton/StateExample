using System;

namespace State
{
  public interface IPlayerState
  {
    void Start(IPlayer player, decimal money, decimal stock);
    void Buy(IPlayer player, decimal amount, decimal price);
    void Sell(IPlayer player, decimal amount, decimal price);
  }
}