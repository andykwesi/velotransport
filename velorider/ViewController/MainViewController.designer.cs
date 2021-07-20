// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace velorider
{
	[Register ("MainViewController")]
	partial class MainViewController
	{
		[Outlet]
		UIKit.UIButton checkDestination { get; set; }

		[Outlet]
		UIKit.UIButton checkLocation { get; set; }

		[Outlet]
		UIKit.UIButton destinationButtonBar { get; set; }

		[Outlet]
		UIKit.UIButton favoritePlacesButton { get; set; }

		[Outlet]
		UIKit.UIView locationBar { get; set; }

		[Outlet]
		UIKit.UIButton locationCheckbox { get; set; }

		[Outlet]
		UIKit.UIImageView menuButton { get; set; }

		[Outlet]
		UIKit.UIButton pickupButtonBar { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (locationBar != null) {
				locationBar.Dispose ();
				locationBar = null;
			}

			if (pickupButtonBar != null) {
				pickupButtonBar.Dispose ();
				pickupButtonBar = null;
			}

			if (destinationButtonBar != null) {
				destinationButtonBar.Dispose ();
				destinationButtonBar = null;
			}

			if (locationCheckbox != null) {
				locationCheckbox.Dispose ();
				locationCheckbox = null;
			}

			if (checkLocation != null) {
				checkLocation.Dispose ();
				checkLocation = null;
			}

			if (checkDestination != null) {
				checkDestination.Dispose ();
				checkDestination = null;
			}

			if (menuButton != null) {
				menuButton.Dispose ();
				menuButton = null;
			}

			if (favoritePlacesButton != null) {
				favoritePlacesButton.Dispose ();
				favoritePlacesButton = null;
			}
		}
	}
}
