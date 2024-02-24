using System.Diagnostics.Contracts;

class mathAssignment : Assignment
{
    private string _textbookSection;
    private string _Questions;
    public mathAssignment(string name, string topic, string section, string questions) : base(name, topic)
    {
        _studentName = name;
        _topic = topic;
        _textbookSection = section;
        _Questions = questions;


    }
    public string GetHomeworkList()
    {
        return ($"{_textbookSection} Problems {_Questions}");
    }
}