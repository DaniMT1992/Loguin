namespace Loguin
{
    public partial class App : Application
    {
       
        public App()
        {
            try
            {
                InitializeComponent();

                MainPage = new NavigationPage(new MainPage());
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
