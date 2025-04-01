using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;


namespace MauiLogin.Views;

public partial class PaginaOpcoes : Microsoft.Maui.Controls.TabbedPage
{

    
    

    public PaginaOpcoes()
	{
		InitializeComponent();
        On<Microsoft.Maui.Controls.PlatformConfiguration.Android>()
                .SetToolbarPlacement(ToolbarPlacement.Bottom);


    }
}