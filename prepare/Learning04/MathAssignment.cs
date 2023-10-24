public class MathAssignment : Assignment {
    protected string _textbookSection;

    protected string _problems;

    public MathAssignment(string name, string topic, string section, string problems) {
        base._studentName = name;
        base._topic = topic;
        _textbookSection = section;
        _problems = problems;
    }

    public string GetHomeworkList() {
        return _studentName + " - " + _topic + Environment.NewLine + _textbookSection + " " + _problems;
    }
}