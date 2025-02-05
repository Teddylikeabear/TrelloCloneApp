using System.Collections.Generic;
using Microsoft.Maui.Controls;

namespace TrelloCloneApp;

public partial class CardsPage : ContentPage
{
    public List<Task> ToDoTasks { get; set; }
    public List<Task> InProgressTasks { get; set; }
    public List<Task> DoneTasks { get; set; }

    public CardsPage()
    {
        InitializeComponent();

        // Sample task data
        ToDoTasks = new List<Task>
        {
            new Task { Title = "Design database schema", Status = "Pending", MemberInitial = "JD" },
            new Task { Title = "Setup API endpoints", Status = "Not Started", MemberInitial = "MM" }
        };

        InProgressTasks = new List<Task>
        {
            new Task { Title = "Build authentication module", Status = "In Progress", MemberInitial = "TS" },
            new Task { Title = "Design UI for task cards", Status = "In Progress", MemberInitial = "KR" }
        };

        DoneTasks = new List<Task>
        {
            new Task { Title = "Create GitHub repo", Status = "Completed", MemberInitial = "TM" },
            new Task { Title = "Conduct project kickoff meeting", Status = "Completed", MemberInitial = "AK" }
        };

        // Setting the BindingContext to this page
        BindingContext = this;
    }

    // Simple Task class
    public class Task
    {
        public string Title { get; set; }
        public string Status { get; set; }
        public string MemberInitial { get; set; }
    }
}
