using Xamarin.Forms;

namespace test
{
    public partial class testPage : ContentPage
    {
        public testPage()
        {
            InitializeComponent();

            slider.Value = 0.5;
        }

        void Handle_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            label.Text = string.Format("Value is {0:F2}", e.NewValue);
        }
    }
}
