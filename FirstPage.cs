using Foundation;
using System;
using UIKit;

namespace MovingRental
{
    public partial class FirstPage : UIViewController
	{
		partial void UIButton48_TouchUpInside(UIButton sender)
		{
			Moving M1 = this.Storyboard.InstantiateViewController("Moving") as Moving;
			this.NavigationController.PushViewController(M1, true);
		}

		public FirstPage (IntPtr handle) : base (handle)
        {
        }

		partial void UIButton51_TouchUpInside(UIButton sender)
		{
			Renting R1 = this.Storyboard.InstantiateViewController("Renting") as Renting;
			this.NavigationController.PushViewController(R1, true);
			
		}

		partial void UIButton52_TouchUpInside(UIButton sender)
		{
			Contact C1 = this.Storyboard.InstantiateViewController("Contact") as Contact;
			this.NavigationController.PushViewController(C1, true);
		}

		partial void UIButton53_TouchUpInside(UIButton sender)
		{
			About A1 = this.Storyboard.InstantiateViewController("About") as About;
			this.NavigationController.PushViewController(A1, true);
		}
	}
}