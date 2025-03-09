using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] protected Slider HealthBarSlider;
    [SerializeField] protected Health Health;

    private void Start()
    {
        Init();
    }

    virtual public void ChangeValue()
    {
        HealthBarSlider.value = Health.Quantity;
    }

    private void Init()
    {
        HealthBarSlider.maxValue = Health.Quantity;
        HealthBarSlider.value = Health.Quantity;
    }
}