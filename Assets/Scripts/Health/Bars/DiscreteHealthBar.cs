public class DiscreteHealthBar : SliderHealthBar
{
    private void Start()
    {
        UpdateHealthData();
    }

    protected override void UpdateHealthData()
    {
        _slider.value = _healthStats.CurrentHealth;
    }
}
