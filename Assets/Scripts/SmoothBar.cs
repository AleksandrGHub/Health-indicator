using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SmoothBar : Bar
{
    private float _recoveryRate = 20f;
    private IEnumerator _coroutine;

    protected override void Start()
    {
        base.Start();
        _coroutine = SlowDownChange();
    }

    public override void ChangeValue()
    {
        StopCoroutine(_coroutine);
        _coroutine = SlowDownChange();
        StartCoroutine(_coroutine);
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