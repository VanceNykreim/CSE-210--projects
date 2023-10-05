public class Journal {

    public Journal ()
    {
        Entries = new List<Entry>();
    }
    public string JournalName {get; set;}

    public List<Entry> Entries {get; set;}


}