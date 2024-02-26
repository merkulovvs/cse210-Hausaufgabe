public class Running : Activity
{
    private int _distance;

    public override int GetDistance()
    {
        return _distance;
    }

    public override DateTime GetPace()
    {
        return base.GetPace();
    }

    public override float GetSpeed()
    {
        return base.GetSpeed();
    }

}