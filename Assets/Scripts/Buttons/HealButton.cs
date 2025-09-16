using UnityEngine;
using UnityEngine.UI;

[RequireComponent (typeof(Button))]
public class HealButton : MonoBehaviour
{
    [SerializeField] private Vitality _vitality;
    [SerializeField, Range(0, 100)] private float _healAmount = 20f;

    private Button _button;
    private IHealable _healable;

    private void Awake()
    {
        _button = GetComponent<Button>();
        _healable = _vitality;
    }

    private void OnEnable()
    {
        _button.onClick.AddListener(Heal);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(Heal);   
    }

    private void Heal()
    {
        _healable.Heal(_healAmount);
    }
}
