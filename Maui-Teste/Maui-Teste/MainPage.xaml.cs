namespace Maui_Teste;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{


		if (InputText.Text == null)
		{
			Label1.Text = "Você não digitou nada no campo de texto acima";
		}
		else 
		{
			Label1.Text = $"Você digitou '{InputText.Text}' no campo acima";
		}

        SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

