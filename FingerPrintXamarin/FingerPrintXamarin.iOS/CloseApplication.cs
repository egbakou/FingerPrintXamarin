using FingerPrintXamarin.iOS;
using System.Threading;
using Xamarin.Forms;

[assembly: Dependency(typeof(CloseApplication))]
namespace FingerPrintXamarin.iOS
{
    public class CloseApplication : ICloseApplication
    {
        public void closeApplication()
        {
            Thread.CurrentThread.Abort();
        }
    }
}