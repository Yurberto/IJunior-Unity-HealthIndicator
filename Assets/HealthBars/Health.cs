using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField, Range(50, 100)] private float _maxValue = 100;
    [SerializeField, Range(0, 100)] private float _currentValue = 100;

    public event Action HealthChanged;

    public float MaxHealth => _maxValue;
    public float CurrentHealth => _currentValue;

    private void OnValidate()
    {
        _currentValue = Mathf.Clamp(_currentValue, 0, _maxValue);
    }

    public void Heal(float healAmount)
    {
        if (healAmount < 0)
            return;

        _currentValue = Mathf.Min(_currentValue + healAmount, _maxValue);
        HealthChanged?.Invoke();
    }

    public void TakeDamage(float damage)
    {
        if (damage < 0)
            return;

        _currentValue = Math.Max(_currentValue - damage, 0);
        HealthChanged?.Invoke();
    }
}
