public class Activity
{
   private DateTime _date;
    private DateTime _time;
    private int _length;

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