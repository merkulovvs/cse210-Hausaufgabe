public class Activity
{
    DateTime _date;
    DateTime _time;
    int _length;

    public virtual int GetDistance()
    {
        return _length;
    }

    public virtual DateTime GetPace()
    {
        return _time;
    }

    public virtual float GetSpeed()
    {
        return 0f;
    }

    public virtual void GetSummary()
    {

    }
}