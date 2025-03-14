namespace AppMenuEventos;

public partial class KmMt : ContentPage
{
	public KmMt()
	{
		InitializeComponent();
	}

	private void btnConverterOnClicked(object sender, EventArgs e)
	{
		float metros;

		metros = float.Parse(etrKilometros.Text) * 1000;

		etrMetros.Text = metros.ToString();

        DisplayAlert("Km > m",
			$"{metros} m",
			"Ok");

    }

	private void btnLimparOnClicked(object sender, EventArgs e)
	{
		etrKilometros.Text = "";
		etrMetros.Text = "";
	}

}