using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace HelloApp.ImagePages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImagePage : ContentPage
    {
        [Obsolete]
        public ImagePage()
        {
            InitializeComponent();
            //var imageSource = (UriImageSource)ImageSource.FromUri(new Uri('http://...'));
            /*
            var imageSource = new UriImageSource { Uri = new Uri("https://i.picsum.photos/id/9/1920/1080.jpg") };
            //images are chached by default when using xaml
            imageSource.CachingEnabled = false;

            image.Source = imageSource;
            */
            //image.Source = ImageSource.FromResource("HelloApp.Images.amenda.JPG");
            //btn.Image = (FileImageSource)ImageSource.FromFile("clock.png");

        }
    }
}