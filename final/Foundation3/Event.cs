public class Event
{
    private string _eventTitle;
    private string _description;
    
    private DateTime _date;

    private DateTime _time;

    private Address _address;

    public Event(string title, string description, DateTime date, DateTime time, Address address)
    {
        _eventTitle = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void FullDetails()
    {

    }

    public void ShortDescription()
    {

    }

    public void StandardDetails()
    {

    }
}