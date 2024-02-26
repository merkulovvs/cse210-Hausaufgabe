public class Cycling : Activity
{
    private float _speed;

    public override float GetSpeed()
    {
        return _speed;
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