using UnityEngine;

public class SmoothHealthBar : HealthBar
{
    private float _changeRate = 25f;

    private void Update()
    {
        ChangeValue();
    }

    public override void ChangeValue()
    {
        HealthBarSlider.value = Mathf.MoveTowards(HealthBarSlider.value, Health.Quantity, _changeRate * Time.deltaTime);
    }
}