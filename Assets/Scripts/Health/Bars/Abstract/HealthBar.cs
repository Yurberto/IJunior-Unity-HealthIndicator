using UnityEngine;

public abstract class HealthBar : MonoBehaviour
{
    [SerializeField] protected Vitality _vitality;

    protected void OnEnable()
    {
        _vitality.HealthChanged += UpdateHealthData;
    }

    protected void OnDisable()
    {
        _vitality.HealthChanged -= UpdateHealthData;
    }

    protected abstract void UpdateHealthData();
}
