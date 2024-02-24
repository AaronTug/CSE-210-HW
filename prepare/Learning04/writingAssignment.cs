class writingAssignment : Assignment
{
    private string _title;

    public writingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _studentName = name;
        _topic = topic;
        _title = title;
    }

    public string GetWritingInfo()
    {
        return ($"{_studentName} - {_topic}\n{_title}");
    }

}