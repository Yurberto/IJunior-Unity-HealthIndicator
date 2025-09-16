using System;

public interface IHealthStats
{
    public event Action HealthChanged;

    public float CurrentHealth { get; }
    public float MaxHealth { get; }
}
