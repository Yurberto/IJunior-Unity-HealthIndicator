using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public abstract class SliderHealthBar : HealthBar
{
    protected Slider _slider;

    protected virtual void Awake()
    {
        _slider = GetComponent<Slider>();

        _slider.minValue = 0;
        _slider.maxValue = 1;

        _slider.value = _vitality.CurrentHealth / _vitality.MaxHealth;
    }
}
