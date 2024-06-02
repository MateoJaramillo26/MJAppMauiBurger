using Android.App;
using Android.Runtime;

namespace MJAppMauiBurger
{
    [Application]
    public class MainApplication : MauiApplication
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership)
            : base(handle, ownership)
        {
        }

        protected override MauiApp CreateMauiApp() => MJMauiProgram.CreateMauiApp();
    }
}
