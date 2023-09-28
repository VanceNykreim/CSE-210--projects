public class Job 
{

public string Company;
public string JobTitle;

public int StartYear;

public int EndYear;

public Job()
{

}

public void DisplayJobInfo()
{
    Console.WriteLine($"{JobTitle} ({Company})");
}
}