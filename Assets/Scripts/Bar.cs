using UnityEngine;
using UnityEngine.UI;

public class Bar : MonoBehaviour
{
    [SerializeField] protected Slider Slider;
    [SerializeField] protected Health Health;

    private void OnEnable()
    {
        Health.QuantityChange += ChangeValue;
    }

    private void OnDisable()
    {
        Health.QuantityChange -= ChangeValue;
    }

    private void Start()
    {
        Init();
    }

    virtual public void ChangeValue()
    {
        Slider.value = Health.Quantity;
    }

    private void Init()
    {
        Slider.maxValue = Health.Quantity;
        Slider.value = Health.Quantity;
    }
}