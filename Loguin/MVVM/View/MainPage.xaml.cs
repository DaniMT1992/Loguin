namespace Loguin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void Loguin_Clicked(object sender, EventArgs e)
        {
            string enteredEmail = emailEntry.Text;
            string enteredPassword = passwordEntry.Text;
            if (enteredEmail == "Andrea9@hotmail.com" && enteredPassword == "1234567")
                Navigation.PushAsync(new Loguin.MVVM.View.MenuView());
            else
                DisplayAlert("Error", "Correo o Contraseña incorrectos", "Ok");
        }
    }
}