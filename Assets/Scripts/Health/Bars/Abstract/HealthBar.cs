using UnityEngine;

public abstract class HealthBar : MonoBehaviour
{
    [SerializeField] protected Vitality Vitality;

    protected void OnEnable()
    {
        Vitality.HealthChanged += UpdateHealthData;
    }

    protected void OnDisable()
    {
        Vitality.HealthChanged -= UpdateHealthData;
    }

    protected abstract void UpdateHealthData();
}
