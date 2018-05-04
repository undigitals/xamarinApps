using Xamarin.Forms;

namespace test
{
    public partial class testPage : ContentPage
    {
        public testPage()
        {
            InitializeComponent();
        }
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Title", "Hello world", "ok");
        }

    }
}
