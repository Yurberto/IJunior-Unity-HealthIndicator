using UnityEngine;
using UnityEngine.UI;

public abstract class ImageHealthBar : HealthBar
{
    [SerializeField] protected FillZone FillZone;

    protected virtual void Awake()
    {
        FillZone.ApplyFill(Health.CurrentValue / Health.MaxValue);
    }
}
