using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    private float _maxQuantity = 100f;
    private float _minQuantity = 0;

    public event Action QuantityChange;

    public float Quantity { get; private set; }

    private void Awake()
    {
        Quantity = _maxQuantity;
    }

    public void Increase(float health)
    {
        if (IsPositive(health))
        {
            Quantity = Mathf.Clamp(Quantity + health, _minQuantity, _maxQuantity);
            QuantityChange?.Invoke();
        }
    }

    public void Decrease(float damage)
    {
        if (IsPositive(damage))
        {
            Quantity = Mathf.Clamp(Quantity - damage, _minQuantity, _maxQuantity);
            QuantityChange?.Invoke();
        }
    }

    private bool IsPositive(float number)
    {
        return number >= 0;
    }
}