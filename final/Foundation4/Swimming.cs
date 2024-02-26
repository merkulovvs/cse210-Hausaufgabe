public class Swimming : Activity
{
    private int _laps;

    public override float GetSpeed()
    {
        return 0f;
    }

    public override DateTime GetPace()
    {
        return base.GetPace();
    }

    public override int GetDistance()
    {
        return 0;
    }
}