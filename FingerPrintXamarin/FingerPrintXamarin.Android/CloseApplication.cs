
using Android.App;
using FingerPrintXamarin.Droid;
using Plugin.CurrentActivity;
using Xamarin.Forms;

[assembly: Dependency(typeof(CloseApplication))]
namespace FingerPrintXamarin.Droid
{
    public class CloseApplication : ICloseApplication
    {
        public void closeApplication()
        {
            Activity activity = CrossCurrentActivity.Current.Activity;
            activity.FinishAffinity();
        }
    }
}