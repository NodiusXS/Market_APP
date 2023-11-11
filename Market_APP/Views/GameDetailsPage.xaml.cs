using Market_APP.Models;

namespace Market_APP.Views;

public partial class GameDetailsPage : ContentPage
{
	public GameDetailsPage(Game game)
	{
        InitializeComponent();

        this.BindingContext = game;
    }

    async void BackButton_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PopAsync();
    }
}