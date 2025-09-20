public class DiscreteHealthBar : SliderHealthBar
{
    private void Start()
    {
        UpdateHealthData();
    }

    protected override void UpdateHealthData()
    {
        Slider.value = Health.CurrentHealth / Health.MaxHealth;
    }
}
