public class HealthButtonHandler : DamageButtonHandler
{
    protected override void ChangeHealth(float value)
    {
        Health.Increase(value);
    }
}