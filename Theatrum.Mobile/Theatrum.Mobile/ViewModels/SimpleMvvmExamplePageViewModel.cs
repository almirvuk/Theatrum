using System.Collections.ObjectModel;
using Theatrum.Mobile.UI.Models;
using System.Windows.Input;
using Xamarin.Forms;
using System.Linq;

namespace Theatrum.Mobile.UI.ViewModels
{
    public class SimpleMvvmExamplePageViewModel
    {
        public ObservableCollection<Car> Cars { get; set; }

        public ICommand SetStatusCommand { get; private set; }
        
        public SimpleMvvmExamplePageViewModel()
        {
            // Set simple dummy data for our ObservableCollection of Cars
            Cars = new ObservableCollection<Car>()
            {
                new Car()
                {
                    Name = "Audi R8",
                    Seen = false
                },

                new Car()
                {
                    Name = "BMW M5",
                    Seen = false
                },

                new Car()
                {
                    Name = "Ferrari 430 Scuderia",
                    Seen = false
                },

                new Car()
                {
                    Name = "Lamborghini Veneno",
                    Seen = false
                },

                new Car()
                {
                    Name = "Mercedes-AMG GT R",
                    Seen = false
                }
            };

            SetStatusCommand = new Command(SetStatus);
        }

        private void SetStatus()
        {
            Car selectedCar = Cars.Where(c => c.Seen == false)
                .FirstOrDefault();

            if (selectedCar != null)
            {
                // Change the value and update UI automatically
                selectedCar.Seen = true;
            }
        }
    }
}
