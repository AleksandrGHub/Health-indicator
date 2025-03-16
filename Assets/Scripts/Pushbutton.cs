using UnityEngine;
using UnityEngine.UI;

public abstract class Pushbutton : MonoBehaviour
{
    [SerializeField] protected Health Health;
    [SerializeField] protected float Value;
    [SerializeField] private Button _button;

    private void OnEnable()
    {
        _button.onClick.AddListener(ChangeHealth);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(ChangeHealth);
    }

    protected abstract void ChangeHealth();
}