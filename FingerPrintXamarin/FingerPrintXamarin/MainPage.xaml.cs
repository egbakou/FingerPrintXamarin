using Plugin.Fingerprint;
using Plugin.Fingerprint.Abstractions;
using System.ComponentModel;
using Xamarin.Forms;

namespace FingerPrintXamarin
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            FingerPrintAsync();
        }

        async void FingerPrintAsync()
        {
            var availableResult = await CrossFingerprint.Current.GetAvailabilityAsync(false);

            if (availableResult.HasFlag(FingerprintAvailability.Available))
            {
                var result = await CrossFingerprint.Current.AuthenticateAsync("Prove you have fingers!");
                if (result.Authenticated)
                {
                    Content.IsVisible = true;
                }
                else
                {
                    //System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();
                    DependencyService.Get<ICloseApplication>().closeApplication();
                }
            }else
            {
                await DisplayAlert("FingerPrint", "Not available", "OK");
                Content.IsVisible = true;
            }

            
        }

        
    }
}
