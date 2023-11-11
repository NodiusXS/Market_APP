using Microsoft.Extensions.Logging;
using Microsoft.Maui.LifecycleEvents;

namespace Market_APP
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
#pragma warning disable CS8321 // Локальная функция объявлена, но не используется
            //async Task LoadMauiAsset()
            //{
            //    using var stream = await FileSystem.OpenAppPackageFileAsync("AboutAssets.txt");
            //    using var reader = new StreamReader(stream);

            //    var contents = reader.ReadToEnd();
            //}
#pragma warning restore CS8321 // Локальная функция объявлена, но не используется
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                })
            .ConfigureLifecycleEvents(events =>
             {
#if ANDROID
                 events.AddAndroid(android => android
                     .OnCreate((activity, bundle) => MakeStatusBarTranslucent(activity)));

                 static void MakeStatusBarTranslucent(Android.App.Activity activity)
                 {
                     activity.Window.SetFlags(Android.Views.WindowManagerFlags.LayoutNoLimits, Android.Views.WindowManagerFlags.LayoutNoLimits);

                     activity.Window.ClearFlags(Android.Views.WindowManagerFlags.TranslucentStatus);

                     activity.Window.SetStatusBarColor(Android.Graphics.Color.Transparent);
                 }
#endif
             });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}