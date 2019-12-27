using Theatrum.Mobile.UI.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Theatrum.Mobile.UI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SimpleMvvmExamplePage : ContentPage
    {
        public SimpleMvvmExamplePage()
        {
            InitializeComponent();

            BindingContext = new SimpleMvvmExamplePageViewModel();
        }
    }
}