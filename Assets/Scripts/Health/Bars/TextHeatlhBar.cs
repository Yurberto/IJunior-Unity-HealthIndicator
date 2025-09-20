using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class TextHeatlhBar : HealthBar
{
    private TextMeshProUGUI _text;

    private void Awake()
    {
        _text = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        UpdateHealthData();
    }

    protected override void UpdateHealthData()
    {
        _text.text = ((int)_vitality.CurrentHealth).ToString() + "/" + ((int)_vitality.MaxHealth).ToString(); 
    }
}
