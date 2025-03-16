using TMPro;
using UnityEngine;

public class TextBar : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private TextMeshProUGUI _textField;

    private string _maxHealthValue;

    private void OnEnable()
    {
        _health.QuantityChange += ChangeField;
    }

    private void OnDisable()
    {
        _health.QuantityChange -= ChangeField;
    }

    private void Start()
    {
        Init();
    }

    public void ChangeField()
    {
        _textField.text = _health.Quantity.ToString() + "/" + _maxHealthValue;
    }

    private void Init()
    {
        _maxHealthValue = _health.Quantity.ToString();
        ChangeField();
    }
}