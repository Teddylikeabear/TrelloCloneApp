namespace TrelloCloneApp;

public partial class WelcomePage : ContentPage
{
	public WelcomePage()
	{
		InitializeComponent();
	}

    private async void OnSignUpClicked(object sender, EventArgs e)
    {
        // Navigate to where you sign up and log in on the trello app 
        await Launcher.OpenAsync(new Uri("https://id.atlassian.com/signup?productHint=trello.enterprise&continue=..."));
    }


    private async void OnLoginClicked(object sender, EventArgs e)
    {
        // Navigate to Dashboard Page after login
        await Navigation.PushAsync(new DashboardPage());
    }
}