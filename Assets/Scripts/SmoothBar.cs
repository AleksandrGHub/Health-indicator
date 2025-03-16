using System.Collections;
using UnityEngine;

public class SmoothBar : Bar
{
    private float _recoveryRate = 10f;

    public override void ChangeValue()
    {
        StartCoroutine(SlowDownChange());
    }

    private IEnumerator SlowDownChange()
    {
        while (Slider.value != Health.Quantity)
        {
            Slider.value = Mathf.MoveTowards(Slider.value, Health.Quantity, _recoveryRate * Time.deltaTime);
            yield return null;
        }
    }
}