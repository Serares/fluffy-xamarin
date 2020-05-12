using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HelloApp.Services;
using HelloApp.Views;
using HelloApp.ImagePages;

namespace HelloApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new RoundImage();
        }
        //https://i.picsum.photos/id/9/1920/1080.jpg

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
