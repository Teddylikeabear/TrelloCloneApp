using System.Collections.ObjectModel;

namespace TrelloCloneApp;

public partial class OfflineBoardsPage : ContentPage
{
    public ObservableCollection<BoardItem> Boards { get; set; }

    public OfflineBoardsPage()
    {
        InitializeComponent();

        Boards = new ObservableCollection<BoardItem>
        {
            new BoardItem { Title = "Project Management", Color = "#FF5733", IsSelected = false },
            new BoardItem { Title = "TaskConnect", Color = "#C70039", IsSelected = false },
        };

        BindingContext = this;
    }
}

public class BoardItem
{
    public string Title { get; set; }
    public string Color { get; set; }
    public bool IsSelected { get; set; }
}
