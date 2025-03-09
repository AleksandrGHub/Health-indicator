using UnityEngine;

public class Health : MonoBehaviour
{
    private float _maxQuantity = 100;
    private float _minQuantity = 0;

    public float Quantity { get; private set; }

    private void Awake()
    {
        Quantity = _maxQuantity;
    }

    public void Increase(float health)
    {
        if (TryCheckPositivity(health))
        {
            Quantity = Mathf.Clamp(Quantity + health, _minQuantity, _maxQuantity);
        }
    }

    public void Decrease(float damage)
    {
        if (TryCheckPositivity(damage))
        {
            Quantity = Mathf.Clamp(Quantity - damage, _minQuantity, _maxQuantity);
        }
    }

    private bool TryCheckPositivity(float number)
    {
        return number >= 0;
    }
}