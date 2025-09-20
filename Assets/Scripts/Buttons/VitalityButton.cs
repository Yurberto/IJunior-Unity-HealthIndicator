using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public abstract class VitalityButton : MonoBehaviour
{
    [SerializeField] protected Vitality _vitality;
    
    protected Button _button;

    protected void Awake()
    {
        _button = GetComponent<Button>();
    }

    protected void OnEnable()
    {
        _button.onClick.AddListener(HandleClick);
    }

    protected void OnDisable()
    {
        _button.onClick.RemoveListener(HandleClick);
    }

    protected abstract void HandleClick();
}
