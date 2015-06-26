using System;
using System.Text;

public class Project
{
    private string name;
    private DateTime startDate;
    private string details;
    private string state;


    public Project(string name, DateTime startDate, string details, string state)
    {
        this.Name = name;
        this.StartDate = startDate;
        this.Details = details;
        this.State = state;

    }
    public string Name 
    {
        get { return this.name; } 
    
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("value","Name cannot be null, empty or whitespace.");
            }
            this.name = value;
        }
    }

    public DateTime StartDate
    {
        get { return this.startDate;}

        set { this.startDate = value; }
    }

    public string Details 
    {
        get { return this.details; }

        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("value", "Details cannot be null, empty or whitespace.");
            }
            this.details = value;
        }
    }

    public string State
    {
        get { return this.state; }

        set
        {
            if (string.IsNullOrWhiteSpace(value) || value != "closed" && value != "open")
            {
                throw new ArgumentException("Invalid project statement.");
            }
            this.state = value;
        }
    }

    public void ClosePoject()
    {
        this.State = "closed";
    }

    public static void CloseProject(Project project)
    {
        project.state = "closed";
    }

    public override string ToString()
    {
        var project = new StringBuilder();

        project.AppendLine(string.Format("Project name: {0}, Details: {1}, Start date: {2}, State {3}"
            , this.Name, this.Details, this.StartDate, this.State));

        return project.ToString();
    }
}
