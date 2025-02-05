namespace TrelloCloneApp;

public partial class DashboardPage : ContentPage
{
	public DashboardPage()
	{
		InitializeComponent();
	}

    private async void OnCardsClicked(object sender, EventArgs e)
    {
        // Navigate to Cards Page after pressing cards button 
        await Navigation.PushAsync(new CardsPage());
    }

    private async void OnTemplatesClicked(object sender, EventArgs e)
    {
        // Navigate to templates Page after pressing templates button 
        await Navigation.PushAsync(new TemplatesPage());
    }

    private async void OnOfflineBoardsClicked(object sender, EventArgs e)
    {
        // Navigate to offlineboards Page after pressing offline boards button
        await Navigation.PushAsync(new OfflineBoardsPage());
    }

    private async void OnHelpClicked(object sender, EventArgs e)
    {
        // Navigate to help Page after pressing help button
        await Navigation.PushAsync(new HelpPage());
    }

    private async void OnSettingsClicked(object sender, EventArgs e)
    {
        // Navigate to settingd Page after pressing settings button 
        await Navigation.PushAsync(new SettingsPage());
    }
}