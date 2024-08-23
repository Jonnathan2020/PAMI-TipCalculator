namespace PAMI_TipCalculator
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void SetLowTip_Clicked(object sender, EventArgs e)
        {
            Slider.ValueProperty = 15;
        }

        private void SetHighTip_Clicked(object sender, EventArgs e)
        {

        }

        private void RoundUpButton_Clicked(object sender, EventArgs e)
        {

        }

        private void RoundDownButton_Clicked(object sender, EventArgs e)
        {

        }
    }

}
