using System.Security.AccessControl;

namespace AppDiasVividos2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void btnCalcularDiasOnClicked(object sender, EventArgs e)
        {
            int diasvividos = 0;

            diasvividos = int.Parse(etrIdade.Text) * 365;

            etrDiasVividos.Text = diasvividos.ToString();

            DisplayAlert( "APP DIAS VIVIDOS",
                $"Você já viveu {diasvividos} dias!",
                "Ok");
        }

        private void btnLimparOnClicked(object sender, EventArgs e)
        {
            etrIdade.Text = "";
            etrDiasVividos.Text = "";
        }

    }

}
