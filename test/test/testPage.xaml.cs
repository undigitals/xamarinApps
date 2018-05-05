using Xamarin.Forms;

namespace test
{
    public partial class testPage : ContentPage
    {
        public testPage()
        {
            InitializeComponent();

            slider.Value = 0.5;

            if (RuntimePlatform.iOS)
                Padding = new Thickness(0, 20, 0, 0);
            else if (Device.OS == TargetPlatform.Android)
                Padding = new Thickness(10, 20, 0, 0);
            else if (Device.OS == TargetPlatform.WinPhone)
                Padding = new Thickness(30, 20, 0, 0);
            
        }
    }
}
