using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public abstract class SliderHealthBar : HealthBar
{
    protected Slider Slider;

    protected virtual void Awake()
    {
        Slider = GetComponent<Slider>();

        Slider.minValue = 0;
        Slider.maxValue = 1;

        Slider.value = Health.CurrentHealth / Health.MaxHealth;
    }
}
