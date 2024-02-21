public class Comment
{
    private string _commentatorName;
    private string _commentText;

    public Comment(string name, string comment)
    {
        _commentatorName = name;
        _commentText = comment;
    }

    public string GetName()
    {
        return _commentatorName;
    }

    public string GetText()
    {
        return _commentText;
    }
}