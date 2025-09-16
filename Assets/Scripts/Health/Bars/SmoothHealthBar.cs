using System.Collections;
using UnityEngine;

public class SmoothHealthBar : SliderHealthBar
{
    [SerializeField, Range(0.1f, 10.0f)] private float _pointsPerTimePeriod = 1.0f;
    [SerializeField, Range(0.0f, 1.0f)] private float _timePeriod = 0.1f;

    private void Start()
    {
        _slider.value = _healthStats.CurrentHealth;
    }

    protected override void UpdateHealthData()
    {
        StartCoroutine(ChangeHealthCoroutine());
    }

    private IEnumerator ChangeHealthCoroutine()
    {
        var wait = new WaitForSeconds(_timePeriod);

        while (_slider.value != _healthStats.CurrentHealth)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, _healthStats.CurrentHealth, _pointsPerTimePeriod);
            yield return wait;
        }
    }
}
