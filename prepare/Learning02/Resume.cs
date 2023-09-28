using System.Threading.Tasks.Dataflow;

class Resume 
{
    public string Name { get; set; }

    public List<Job> Jobs  = new List<Job>();

    public Resume ()
    {

    }

    //methods
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Jobs:");
        foreach (Job job in Jobs)
        {
            job.DisplayJobInfo();
        }
    }
}