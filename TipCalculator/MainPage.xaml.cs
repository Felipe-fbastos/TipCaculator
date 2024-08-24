

namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void setLowTip_Clicked(object sender, EventArgs e)
        {
            TipSlider.Value = 15;
            TipPercentLabel.Text = TipSlider.Value.ToString() + "%";
        }

        private void setHighTip_Clicked(object sender, EventArgs e)
        {
            TipSlider.Value = 20; //Atribui valor ao Slider 
            TipPercentLabel.Text = TipSlider.Value.ToString() + "%"; 
        }

        private void RoundUpButton_Clicked(object sender, EventArgs e)
        {

        }

        private void RoundDownButton_Clicked(object sender, EventArgs e)
        {

        }

        private void TipSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            TipPercentLabel.Text = TipSlider.Value.ToString("#") + "%"; 
        }

        
        private void AmountEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            //PEgar o valor inserido ex:100
            //Calcular o valor da gorjeta de acordo com a porcentagem
            //Calcular o valor total, sendo a soma do valor + a gorjeta

            double valor = Convert.ToDouble(AmountEntry.Text);
            double valorgorjeta = valor * (TipSlider.Value / 100);
            double valortotal = valorgorjeta + valor;

            totalLabel.Text = valortotal.ToString("C");
            TipLabel.Text = valorgorjeta.ToString("C"); 
        }
    }

}
