namespace AppMenuEventos;

public partial class KmMt : ContentPage
{
	public KmMt()
	{
		InitializeComponent();
	}

	private void btnCoverterOnClicked(object sender, EventArgs e)
	{
		float metros;

		metros = float.Parse(etrKilometros.Text) * 1000;

		etrMetros.Text = metros.ToString();

	}

	private void btnLimparOnClicked(object sender, EventArgs e)
	{
		etrKilometros.Text = "";
		etrMetros.Text = "";
	}

}