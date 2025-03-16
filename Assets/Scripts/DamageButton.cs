public class DamageButton : Pushbutton
{
    protected override void ChangeHealth()
    {
        Health.Decrease(Value);
    }
}