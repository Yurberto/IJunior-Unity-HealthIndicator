using UnityEngine;

public abstract class HealthBar : MonoBehaviour
{
    [SerializeField] protected Vitality _vitality;

    protected IHealthStats _healthStats;

    protected void OnEnable()
    {
        _healthStats.HealthChanged += UpdateHealthData;
    }

    protected void OnDisable()
    {
        _healthStats.HealthChanged -= UpdateHealthData;
    }

    protected abstract void UpdateHealthData();
}
