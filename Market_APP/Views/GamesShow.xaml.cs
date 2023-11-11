using Market_APP.Models;
using Market_APP.Services;

namespace Market_APP.Views;

public partial class GamesShow : ContentPage
{
    private const uint AnimationDuration = 800u;
    public GamesShow()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        lstPopularGames.ItemsSource = GameService.GetFeaturedGames();
        lstPopularGamesFullLable.ItemsSource = GameService.GetFeaturedGames();
        lstAllGames.ItemsSource = GameService.GetAllGames();

    }

    async void Games_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        await Navigation.PushAsync(new GameDetailsPage(e.CurrentSelection.First() as Game));
    }

    async void ProfilePic_Clicked(object sender, EventArgs e)
    {
        // Reveal our menu and move the main content out of the view
        _ = MainContentGrid.TranslateTo(-Width * 0.5, Height * 0.1, AnimationDuration, Easing.CubicIn);
        await MainContentGrid.ScaleTo(0.8, AnimationDuration);
        _ = MainContentGrid.FadeTo(0.8, AnimationDuration);
    }

    async void GridArea_Tapped(object sender, EventArgs e)
    {
        await CloseMenu();
    }

    private async Task CloseMenu()
    {
        //Close the menu and bring back back the main content
        _ = MainContentGrid.FadeTo(1, AnimationDuration);
        _ = MainContentGrid.ScaleTo(1, AnimationDuration);
        await MainContentGrid.TranslateTo(0, 0, AnimationDuration, Easing.CubicIn);
    }
}