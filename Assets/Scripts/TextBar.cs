using TMPro;
using UnityEngine;

public class TextBar : Bar
{
    [SerializeField] private TextMeshProUGUI _textField;

    protected override void OnEnable()
    {
        base.OnEnable();
        Health.QuantityChange += ShowValue;
    }

    protected override void OnDisable()
    {
        base.OnDisable();
        Health.QuantityChange -= ShowValue;
    }

    protected override void Start()
    {
        base.Start();
        ShowValue();
    }

    private void ShowValue()
    {
        _textField.text = Slider.value + "/" + Slider.maxValue;
    }
}