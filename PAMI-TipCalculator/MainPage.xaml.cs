using System.Diagnostics;

namespace PAMI_TipCalculator
{
    public partial class MainPage : ContentPage
    {
        double valorTotal = 0;
        double valorDaGorjeta = 0;
        double valor = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void SetLowTip_Clicked(object sender, EventArgs e)
        {
            TipSlider.Value = 15;
            TipPercentLabel.Text = TipSlider.Value.ToString() + "%";
        }

        private void SetHighTip_Clicked(object sender, EventArgs e)
        {
            TipSlider.Value = 20;
            TipPercentLabel.Text = TipSlider.Value.ToString() + "%";
        }

        private void RoundUpButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                valorTotal = Convert.ToDouble(TotalLabel.Text);
                valorDaGorjeta = Convert.ToDouble(TipLabel.Text);
                valorDaGorjeta = Math.Ceiling(valorDaGorjeta);
                valorTotal = Math.Ceiling(valorTotal);
                TipLabel.Text = valorDaGorjeta.ToString("C");
                TotalLabel.Text = valorTotal.ToString("C");
            }
            catch(Exception ex) 
            { 
                Debug.WriteLine(ex.ToString());
            }
        }

        private void RoundDownButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                valorTotal = Convert.ToDouble(TotalLabel.Text);
                valorDaGorjeta = Convert.ToDouble(TipLabel.Text);
                valorDaGorjeta = Math.Floor(valorDaGorjeta);
                valorTotal = Math.Floor(valorTotal);
                TipLabel.Text = valorDaGorjeta.ToString("C");
                TotalLabel.Text = valorTotal.ToString("C");
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }

        private void TipSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            TipPercentLabel.Text = TipSlider.Value.ToString("#.##") + "%";

            try
            {
                valor = Convert.ToDouble(AmountEntry.Text);
                valorDaGorjeta = valor * (TipSlider.Value / 100);
                valorTotal = valorDaGorjeta + valor;

                TotalLabel.Text = valorTotal.ToString("C");
                TipLabel.Text = valorDaGorjeta.ToString("C");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }

        }

        private void AmountEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                valor = Convert.ToDouble(AmountEntry.Text);
                valorDaGorjeta = valor * (TipSlider.Value / 100);
                valorTotal = valorDaGorjeta + valor;

                TotalLabel.Text = valorTotal.ToString();
                TipLabel.Text = valorDaGorjeta.ToString();
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }
    }

}
