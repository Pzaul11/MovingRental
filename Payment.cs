using Foundation;
using System;
using UIKit;

namespace MovingRental
{
    public partial class Payment : UIViewController
    {
		partial void UIButton101_TouchUpInside(UIButton sender)
		{
			FirstPage F1 = this.Storyboard.InstantiateViewController("FirstPage") as FirstPage;
			this.NavigationController.PushViewController(F1, true);
		}

		public Payment (IntPtr handle) : base (handle)
        {
        }

		partial void UIButton102_TouchUpInside(UIButton sender)
		{
			FirstPage F1 = this.Storyboard.InstantiateViewController("FirstPage") as FirstPage;
			this.NavigationController.PushViewController(F1, true);
		}
	}
}