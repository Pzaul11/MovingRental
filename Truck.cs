using Foundation;
using System;
using UIKit;

namespace MovingRental
{
    public partial class Truck : UIViewController
    {
		partial void UIButton97_TouchUpInside(UIButton sender)
		{
			Moving M1 = this.Storyboard.InstantiateViewController("Moving") as Moving;
			this.NavigationController.PushViewController(M1, true);
		}

		public Truck (IntPtr handle) : base (handle)
        {
        }

		partial void UIButton98_TouchUpInside(UIButton sender)
		{
			FirstPage F1 = this.Storyboard.InstantiateViewController("FirstPage") as FirstPage;
			this.NavigationController.PushViewController(F1, true);
		}
	}
}