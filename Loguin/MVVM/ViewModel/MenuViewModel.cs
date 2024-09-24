using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace Loguin.MVVM.ViewModel;

public class MenuViewModel
{
    public ICommand ExpedientesCommand { get; }
    public ICommand CambiarContrasenaCommand { get; }
    public ICommand AcercaDeCommand { get; }
    public ICommand CerrarSesionCommand { get; }
    public ICommand InicioCommand { get; }

    public MenuViewModel()
    {
        ExpedientesCommand = new Command(NavegarAExpedientes);
        CambiarContrasenaCommand = new Command(CambiarContrasena);
        AcercaDeCommand = new Command(AbrirAcercaDe);
        CerrarSesionCommand = new Command(CerrarSesion);
        InicioCommand = new Command(NavegarAInicio);
    }

    private void NavegarAExpedientes()
    {
        Application.Current.MainPage.DisplayAlert("Navegaci�n", "Navegando a Expedientes", "OK");

    }
    private void CambiarContrasena()
    {
        Application.Current.MainPage.DisplayAlert("Acci�n", "Cambiando Contrase�a", "OK");
    }
    private void AbrirAcercaDe()
    {
        Application.Current.MainPage.DisplayAlert("Informaci�n", "Acerca de esta aplicaci�n", "OK");
    }
    private void CerrarSesion()
    {
        Application.Current.MainPage.DisplayAlert("Sesi�n", "Cerrando Sesi�n", "OK");
    }


    private void NavegarAInicio()
    {
        if (Application.Current.MainPage is FlyoutPage flyoutPage)
        {
            flyoutPage.Detail = new NavigationPage(new MainPage()); // Aseg�rate de tener la p�gina de inicio
            flyoutPage.IsPresented = false;
        }
    }
}
