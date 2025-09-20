using UnityEngine;
using UnityEngine.UI;

[RequireComponent (typeof(Button))]
public class HealButton : VitalityButton
{
    [SerializeField, Range(0, 100)] private float _healAmount = 20f;

    protected override void HandleClick()
    {
        Vitality.Heal(_healAmount);
    }
}
