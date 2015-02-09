// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the SecondViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace MvxViewPager.Core.ViewModels
{
    using System.Windows.Input;
    using Cirrious.MvvmCross.ViewModels;

    /// <summary>
    /// Define the SecondViewModel type.
    /// </summary>
    public class SecondViewModel : BaseViewModel
    {
        /// <summary>
        /// Backing field for my property.
        /// </summary>
        private string _name = "Second";


        /// <summary>
        /// Gets or sets my property.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this.SetProperty(ref this._name, value, () => this.Name); }
        }

    }
}
