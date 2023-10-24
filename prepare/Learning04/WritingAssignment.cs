public class WritingAssignment : Assignment {
    
    protected string _title;

    public WritingAssignment(string name, string topic, string title) {
        base._studentName = name;
        base._topic = topic;
        _title = title;
    }
    public string GetWritingInformation() {
        return _studentName + " - " + _topic + Environment.NewLine +_title + " by " + _studentName;
    }
}