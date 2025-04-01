using MauiLogin.Views;
namespace MauiLogin;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private void btnLogin(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PaginaOpcoes());
    }
}