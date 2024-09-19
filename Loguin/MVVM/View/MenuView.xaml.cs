namespace Loguin.MVVM.View;

public partial class MenuView : FlyoutPage
{
	public MenuView()
	{
		InitializeComponent();
	}
    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {

        this.Detail = new NavigationPage(new MainPage());

        this.IsPresented = false;
    }
}