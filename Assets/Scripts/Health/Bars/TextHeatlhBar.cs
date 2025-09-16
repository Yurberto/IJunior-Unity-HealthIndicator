using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class TextHeatlhBar : HealthBar
{
    private TextMeshProUGUI _text;

    private void Awake()
    {
        _text = GetComponent<TextMeshProUGUI>();
        _healthStats = _vitality;
    }

    private void Start()
    {
        UpdateHealthData();
    }

    protected override void UpdateHealthData()
    {
        _text.text = ((int)_healthStats.CurrentHealth).ToString() + "/" + ((int)_healthStats.MaxHealth).ToString(); 
    }
}
