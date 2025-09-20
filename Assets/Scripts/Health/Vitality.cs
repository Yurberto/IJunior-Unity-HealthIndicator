using System;
using UnityEngine;

public class Vitality : MonoBehaviour
{
    [SerializeField, Range(50, 100)] private float _maxHealth = 100;
    [SerializeField, Range(0, 100)] private float _health = 100;

    public event Action HealthChanged;

    public float MaxHealth => _maxHealth;
    public float CurrentHealth => _health;

    private void OnValidate()
    {
        _health = Mathf.Clamp(_health, 0, _maxHealth);
    }

    public void Heal(float healAmount)
    {
        if (healAmount < 0)
            return;

        _health = Mathf.Min(_health + healAmount, _maxHealth);
        HealthChanged?.Invoke();
    }

    public void TakeDamage(float damage)
    {
        if (damage < 0)
            return;

        _health = Math.Max(_health - damage, 0);
        HealthChanged?.Invoke();
    }
}
