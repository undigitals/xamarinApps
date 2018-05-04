using Xamarin.Forms;

namespace test
{
    public partial class testPage : ContentPage
    {
        public testPage()
        {
            InitializeComponent();

            Content = new Label
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Text = "Hello World"
            };
        }

    }
}
