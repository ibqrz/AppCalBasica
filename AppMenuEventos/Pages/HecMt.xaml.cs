namespace AppMenuEventos;

public partial class HecMt : ContentPage
{
	public HecMt()
	{
		InitializeComponent();
	}

    private void btnCoverterOnClicked(object sender, EventArgs e)
    {
        float metros;

        metros = float.Parse(etrHectometros.Text) * 100;

        etrMetros.Text = metros.ToString();

    }

    private void btnLimparOnClicked(object sender, EventArgs e)
    {
        etrHectometros.Text = "";
        etrMetros.Text = "";
    }
}