public class Receptions : Event
{
    private int _registered;

    public Receptions(int registered,string title, string description, DateTime date, DateTime time, Address address) : base(title, description, date, time, address)
    {
        _registered = registered;
    }
}