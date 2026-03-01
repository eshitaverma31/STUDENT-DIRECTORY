namespace TelephoneDirectory
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
            // MainPage = new NavigationPage(new Views.MainPage());
            MainPage = new NavigationPage(new Views.HomePage());
        }
    }
}
