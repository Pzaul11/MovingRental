using Foundation;
using System;
using UIKit;

namespace MovingRental
{
    public partial class Renting : UIViewController
    {
		partial void UIButton84_TouchUpInside(UIButton sender)
		{
			Truck T1 = this.Storyboard.InstantiateViewController("Truck") as Truck;
			this.NavigationController.PushViewController(T1, true);

		}

		public Renting (IntPtr handle) : base (handle)
        {
        }
    }
}