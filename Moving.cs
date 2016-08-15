using Foundation;
using System;
using UIKit;

namespace MovingRental
{
    public partial class Moving : UIViewController
    {
		partial void UIButton59_TouchUpInside(UIButton sender)
		{
			Payment P1 = this.Storyboard.InstantiateViewController("Payment") as Payment;
			this.NavigationController.PushViewController(P1, true);
		}

		public Moving (IntPtr handle) : base (handle)
        {
        }

		partial void UIButton60_TouchUpInside(UIButton sender)
		{
			
			FirstPage F1 = this.Storyboard.InstantiateViewController("FirstPage") as FirstPage;
			this.NavigationController.PushViewController(F1, true);
		}
	}
}