namespace MauiLogin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Login())
            {
                BarTextColor = Color.FromHex("#FFFFFF"),
                BarBackgroundColor = Color.FromHex("#000000"),
                Title = "APP PI"
            };
        }
    }
}
