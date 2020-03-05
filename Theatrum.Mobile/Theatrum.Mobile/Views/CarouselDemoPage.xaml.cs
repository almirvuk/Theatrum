using Theatrum.Mobile.UI.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Theatrum.Mobile.UI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselDemoPage : ContentPage
    {
        public CarouselDemoPage()
        {
            InitializeComponent();

            BindingContext = new CarouselDemoPageViewModel();
        }
    }
}