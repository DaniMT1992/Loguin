namespace Loguin
{
    public partial class App : Application
    {
       
        public App()
        {
            try
            {
                InitializeComponent();

                MainPage = new MainPage();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
