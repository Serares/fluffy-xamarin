using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HelloApp.Services;
using HelloApp.Views;

namespace HelloApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new RelativePage();
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
