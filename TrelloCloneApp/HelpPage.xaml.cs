using System.Collections.ObjectModel;

namespace TrelloCloneApp;

public partial class HelpPage : ContentPage
{
    public ObservableCollection<FAQItem> FAQs { get; set; }
    public ObservableCollection<FeedbackItem> Feedback { get; set; }

    public HelpPage()
    {
        InitializeComponent();

        FAQs = new ObservableCollection<FAQItem>
        {
            new FAQItem { Title = "Delete (Close/Archive) a board",
                Likes = 2974 },
            new FAQItem { Title = "Receive a notification for a due date",
                Likes = 1153 },
            new FAQItem { Title = "Change account information", 
                Likes = 801 },

        };

        Feedback = new ObservableCollection<FeedbackItem>
        {
            new FeedbackItem { Title = "Support Questions",
                Icon = "support_icon.png" },
            new FeedbackItem { Title = "Bug Reports",
                Icon = "bug_icon.png" },
            new FeedbackItem { Title = "Feature Requests",
                Icon = "feature_icon.png" },
        };

        BindingContext = this;
    }
}

public class FAQItem
{
    public string Title { get; set; }
    public int Likes { get; set; }
}

public class FeedbackItem
{
    public string Title { get; set; }
    public string Icon { get; set; }
}
