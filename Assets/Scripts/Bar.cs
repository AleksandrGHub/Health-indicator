using UnityEngine;
using UnityEngine.UI;

public class Bar : MonoBehaviour
{
    [SerializeField] protected Health Health;
    [SerializeField] protected Slider Slider;

    protected virtual void OnEnable()
    {
        Health.QuantityChange += ChangeValue;
    }

    protected virtual void OnDisable()
    {
        Health.QuantityChange -= ChangeValue;
    }

    protected virtual void Start()
    {
        Slider.maxValue = Health.Quantity;
        Slider.value = Health.Quantity;
    }

    public virtual void ChangeValue()
    {
        Slider.value = Health.Quantity;
    }
}