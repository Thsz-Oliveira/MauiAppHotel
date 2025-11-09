using MauiAppHotel.Views;
namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	public ContratacaoHospedagem()
	{
		InitializeComponent();
	}

    private async void BtnSobre_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Sobre());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        try{
            Navigation.PushAsync(new HospedagemContratada());
        }
        catch(Exception ex)
        {
            DisplayAlert("Ops",ex.Message,"OK");
        }
    }
}