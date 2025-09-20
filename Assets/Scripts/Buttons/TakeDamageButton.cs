using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]  
public class TakeDamageButton : VitalityButton
{
    [SerializeField, Range(0, 100)] private float _damage = 20f;

    protected override void HandleClick()
    {
        Vitality.TakeDamage(_damage);   
    }
}
