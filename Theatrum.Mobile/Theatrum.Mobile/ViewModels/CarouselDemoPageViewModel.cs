using System.Collections.ObjectModel;
using Theatrum.Mobile.UI.Models;
using Theatrum.Mobile.UI.Mvvm;

namespace Theatrum.Mobile.UI.ViewModels
{
    public class CarouselDemoPageViewModel : BindableBase
    {
        public ObservableCollection<Car> Cars { get; set; }

        private Car currentItem;
        public Car CurrentItem
        {
            get { return currentItem; }
            set { SetProperty(ref currentItem, value); }
        }

        public CarouselDemoPageViewModel()
        {
            Cars = new ObservableCollection<Car>()
            {
                new Car()
                {
                    Name = "Audi R8",
                    Seen = false,
                    PhotoUrl = "https://www.indigoautogroup.com/inventoryphotos/3228/wuakbafx3l7900354/ip/1.jpg?height=400"
                },

                new Car()
                {
                    Name = "BMW M5",
                    Seen = false,
                    PhotoUrl = "https://s.aolcdn.com/dims-global/dims3/GLOB/legacy_thumbnail/640x400/quality/80/https://s.aolcdn.com/commerce/autodata/images/USC80BMC171A021001.jpg"
                },

                new Car()
                {
                    Name = "Ferrari 430 Scuderia",
                    Seen = false,
                    PhotoUrl = "https://iproxy2.motortrak.com/2008/ferrari/430_scuderia/rosso_corsa_ds_322-Cavallino_Motors_Co._Ltd-ZFFKZ64C000160890-1024-0.jpg"
                },

                new Car()
                {
                    Name = "Lamborghini Veneno",
                    Seen = false,
                    PhotoUrl = "https://www.automobilemag.com/uploads/sites/11/2020/01/2015-Lamborghini-Veneno-Roadster-10.jpg?fit=around%7C875:492"
                },

                new Car()
                {
                    Name = "Mercedes-AMG GT R",
                    Seen = false,
                    PhotoUrl = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2020-mercedes-amg-gt-r-pro-126-1554739776.jpg"
                }
            };

        }
    }
}
