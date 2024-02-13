public class ChecklistGoal : Goal
{
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return "";
    }

    public override string GetStringRepresentation()
    {
        return "";
    }

}