using System;
using System.ComponentModel;
using Theatrum.Mobile.UI.Views;
using Xamarin.Forms;

namespace Theatrum.Mobile.UI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MvvmExample(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SimpleMvvmExamplePage());
        }
    }
}
