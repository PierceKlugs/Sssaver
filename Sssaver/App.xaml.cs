using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Sssaver.Services;
using Sssaver.Views;
[assembly: ExportFont("Oswald-Bold.ttf", Alias = "OsBold")]
[assembly: ExportFont("Oswald-ExtraLight.ttf", Alias = "OsXLight")]
[assembly: ExportFont("Oswald-Light.ttf", Alias = "OsLight")]
[assembly: ExportFont("Oswald-Medium.ttf", Alias = "OsMed")]
[assembly: ExportFont("Oswald-Regular.ttf", Alias = "Os")]
[assembly: ExportFont("Oswald-SemiBold.ttf", Alias = "OsSemiBold")]
namespace Sssaver
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
