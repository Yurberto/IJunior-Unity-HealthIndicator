public class DiscreteHealthBar : ImageHealthBar
{
    private void Start()
    {
        UpdateHealthData();
    }

    protected override void UpdateHealthData()
    {
        FillZone.ApplyFill(Health.CurrentValue / Health.MaxValue);
    }
}
