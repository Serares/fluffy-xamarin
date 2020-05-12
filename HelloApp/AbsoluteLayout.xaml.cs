using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloApp
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AbsolutePage : ContentPage
    {
        public AbsolutePage()
        {
            InitializeComponent();
            var absoluteLayout = new AbsoluteLayout();
            Content = absoluteLayout;

            var aquabox = new BoxView { Color = Color.Aqua };
            absoluteLayout.Children.Add(aquabox, new Rectangle(0, 0, 1, 1), AbsoluteLayoutFlags.All);
            AbsoluteLayout.SetLayoutBounds(aquabox, new Rectangle(0, 0, 1, 1));
            AbsoluteLayout.SetLayoutFlags(aquabox, AbsoluteLayoutFlags.HeightProportional);
        }

    }
}