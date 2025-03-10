using UnityEngine;
using UnityEngine.UI;

public class DamageButtonHandler : MonoBehaviour
{
    [SerializeField] protected Health Health;
    [SerializeField] private float _value;
    [SerializeField] private Button _button;
    [SerializeField] private HealthBar _healthBar;
    [SerializeField] private TextBar _textBar;

    private void Start()
    {
        Init();
    }

    private void Init()
    {
        _button.onClick.AddListener(delegate { ChangeHealth(_value); _healthBar.ChangeValue(); _textBar.ChangeField(); });
    }

    virtual protected void ChangeHealth(float value)
    {
        Health.Decrease(value);
    }
}