using Theatrum.Mobile.UI.Mvvm;

namespace Theatrum.Mobile.UI.Models
{
	public class Car : BindableBase
    {
		private string name;
		public string Name
		{
			get { return name; }
			set { SetProperty(ref name, value);}
		}

		private bool seen;

		public bool Seen
		{
			get { return seen; }
			set { SetProperty(ref seen, value); }
		}
	}
}
