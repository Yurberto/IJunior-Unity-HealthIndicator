using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]  
public class TakeDamageButton : HealthButton
{
    [SerializeField, Range(0, 100)] private float _damage = 20f;

    protected override void HandleClick()
    {
        Health.TakeDamage(_damage);   
    }
}
