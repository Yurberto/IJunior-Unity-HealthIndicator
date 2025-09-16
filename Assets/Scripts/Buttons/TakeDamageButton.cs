using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]  
public class TakeDamageButton : MonoBehaviour
{
    [SerializeField] private Vitality _vitality;
    [SerializeField, Range(0, 100)] private float _damage = 20f;

    private Button _button;
    private IDamageable _damageable;

    private void Awake()
    {
        _button = GetComponent<Button>();
        _damageable = _vitality;
    }

    private void OnEnable()
    {
        _button.onClick.AddListener(DealDamage);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(DealDamage);
    }

    private void DealDamage()
    {
        _damageable.TakeDamage(_damage);   
    }
}
