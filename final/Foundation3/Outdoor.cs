public class Outdoor : Event
{
    private bool _weatherIsGood;

    public Outdoor(bool weather, string title, string description, DateTime date, DateTime time, Address address) : base(title, description, date, time, address)
    {
        _weatherIsGood = weather;
    }
}