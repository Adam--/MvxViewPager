// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the HomeViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace MvxViewPager.Core.ViewModels
{
    using System.Windows.Input;
    using Cirrious.MvvmCross.ViewModels;

    /// <summary>
    /// Define the HomeViewModel type.
    /// </summary>
    public class HomeViewModel : BaseViewModel
    {
        public FirstViewModel First { get; private set; }
        public SecondViewModel Second { get; private set; }
        public ThirdViewModel Third { get; private set; }  

        public HomeViewModel()
        {
            First = new FirstViewModel();
            Second = new SecondViewModel();
            Third = new ThirdViewModel();
        }
    }
}
