using UnityEngine;

public abstract class HealthBar : MonoBehaviour
{
    [SerializeField] protected Health Health;

    protected void OnEnable()
    {
        Health.HealthChanged += UpdateHealthData;
    }

    protected void OnDisable()
    {
        Health.HealthChanged -= UpdateHealthData;
    }

    protected abstract void UpdateHealthData();
}
