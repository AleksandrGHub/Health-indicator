public class HealthButton : Pushbutton
{
    protected override void ChangeHealth()
    {
        Health.Increase(Value);
    }
}