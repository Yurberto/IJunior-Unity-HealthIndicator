using System.Collections;
using UnityEngine;

public class SmoothHealthBar : SliderHealthBar
{
    [SerializeField, Range(0.01f, 1.0f)] private float _changeSpeed = 1.0f;
    [SerializeField, Range(0.1f, 100.0f)] private float _timeFactor = 100.0f;

    private Coroutine _healthChanger;

    protected override void UpdateHealthData()
    {
        if (_healthChanger != null) 
            StopCoroutine(_healthChanger);

        _healthChanger = StartCoroutine(ChangeHealthCoroutine());
    }

    private IEnumerator ChangeHealthCoroutine()
    {
        float start = _slider.value;
        float target = _vitality.CurrentHealth / _vitality.MaxHealth;
        float time = 0;

        while (_slider.value != target)
        {
            _slider.value = Mathf.Lerp(start, target, time);
            time += _changeSpeed / _timeFactor;
            yield return null;
        }
    }
}
