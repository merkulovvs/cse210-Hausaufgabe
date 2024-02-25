using System.Text.RegularExpressions;

public class Lectures : Event
{
    private string _speaker;
    private int _capacity;

    public Lectures(string speaker, int capacity, string title, string description, DateTime date, DateTime time, Address address) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

}