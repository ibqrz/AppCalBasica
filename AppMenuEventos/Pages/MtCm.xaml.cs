namespace AppMenuEventos;

public partial class MtCm : ContentPage
{
	public MtCm()
	{
		InitializeComponent();
	}

    private void btnCoverterOnClicked(object sender, EventArgs e)
    {
        float centimetros;

        centimetros = float.Parse(etrMetros.Text) * 100;

        etrCentimetros.Text = centimetros.ToString();

    }

    private void btnLimparOnClicked(object sender, EventArgs e)
    {
        etrMetros.Text = "";
        etrCentimetros.Text = "";
    }
}