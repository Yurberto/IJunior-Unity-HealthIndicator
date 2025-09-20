using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public abstract class VitalityButton : MonoBehaviour
{
    [SerializeField] protected Health Vitality;
    
    protected Button Button;

    protected void Awake()
    {
        Button = GetComponent<Button>();
    }

    protected void OnEnable()
    {
        Button.onClick.AddListener(HandleClick);
    }

    protected void OnDisable()
    {
        Button.onClick.RemoveListener(HandleClick);
    }

    protected abstract void HandleClick();
}
