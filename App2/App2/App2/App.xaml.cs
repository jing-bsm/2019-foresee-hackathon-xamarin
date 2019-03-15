using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace App2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            DependencyService.Get<ForeseeSDK>().start();
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            DependencyService.Get<ForeseeSDK>().checkIfEligible();
            DependencyService.Get<ForeseeSDK>().increamentWithKey("app_test_1");
            // Handle when your app resumes
        }
    }
}
