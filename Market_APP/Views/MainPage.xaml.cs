namespace Market_APP.Views
{
    public partial class MainPage : ContentPage
    {
#pragma warning disable CS0414 // Полю "MainPage.count" присвоено значение, но оно ни разу не использовано.
        int count = 0;
#pragma warning restore CS0414 // Полю "MainPage.count" присвоено значение, но оно ни разу не использовано.

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            //count++;

            //if (count == 1)
            //    CounterBtn.Text = $"Clicked {count} time";
            //else
            //    CounterBtn.Text = $"Clicked {count} times";

            //SemanticScreenReader.Announce(CounterBtn.Text);
        }

#pragma warning disable CS1998 // В асинхронном методе отсутствуют операторы await, будет выполнен синхронный метод
        protected override async void OnAppearing()
#pragma warning restore CS1998 // В асинхронном методе отсутствуют операторы await, будет выполнен синхронный метод
        {
            base.OnAppearing();

            //if (this.AnimationIsRunning("TransitionAnimation"))
            //    return;

            //var parentAnimation = new Animation();

            ////Games Animation
            //parentAnimation.Add(0, 0.2, new Animation(v => imgMercury.Opacity = v, 0, 1, Easing.CubicIn));
            //parentAnimation.Add(0.1, 0.3, new Animation(v => imgVenus.Opacity = v, 0, 1, Easing.CubicIn));
            //parentAnimation.Add(0.2, 0.4, new Animation(v => imgEarth.Opacity = v, 0, 1, Easing.CubicIn));
            //parentAnimation.Add(0.3, 0.5, new Animation(v => imgMars.Opacity = v, 0, 1, Easing.CubicIn));
            //parentAnimation.Add(0.4, 0.6, new Animation(v => imgJupiter.Opacity = v, 0, 1, Easing.CubicIn));
            //parentAnimation.Add(0.5, 0.7, new Animation(v => imgSaturn.Opacity = v, 0, 1, Easing.CubicIn));
            //parentAnimation.Add(0.6, 0.8, new Animation(v => imgNeptune.Opacity = v, 0, 1, Easing.CubicIn));
            //parentAnimation.Add(0.7, 0.9, new Animation(v => imgUranus.Opacity = v, 0, 1, Easing.CubicIn));

            ////Intro Box Animation
            //parentAnimation.Add(0.7, 1, new Animation(v => frmIntro.Opacity = v, 0, 1, Easing.CubicIn));

            ////Commit the animation
            //parentAnimation.Commit(this, "TransitionAnimation", 16, 3000, null, null);
        }

#pragma warning disable CS1998 // В асинхронном методе отсутствуют операторы await, будет выполнен синхронный метод
        async void ExploreNow_Clicked(System.Object sender, System.EventArgs e)
#pragma warning restore CS1998 // В асинхронном методе отсутствуют операторы await, будет выполнен синхронный метод
            => Application.Current.MainPage = new NavigationPage(new GamesShow());

    }
}