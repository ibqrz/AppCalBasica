namespace AppMenuEventos;

public partial class HecMt : ContentPage
{
	public HecMt()
	{
		InitializeComponent();
	}

    private void btnConverterOnClicked(object sender, EventArgs e)
    {
        float metros;

        metros = float.Parse(etrHectometros.Text) * 100;

        etrMetros.Text = metros.ToString();

        DisplayAlert("Hm > m",
            $"{metros} m",
            "Ok");

    }

    private void btnLimparOnClicked(object sender, EventArgs e)
    {
        etrHectometros.Text = "";
        etrMetros.Text = "";
    }
}