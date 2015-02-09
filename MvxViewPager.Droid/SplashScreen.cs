// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the SplashScreen type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace MvxViewPager.Droid
{
    using Android.App;

    using Cirrious.MvvmCross.Droid.Views;

    /// <summary> 
    /// Defines the SplashScreen type.
    /// </summary>
    [Activity(Label = "MvxViewPager.Droid", MainLauncher = true, Icon = "@drawable/icon", NoHistory = true)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SplashScreen"/> class.
        /// </summary>
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}