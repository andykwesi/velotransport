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
	[Register ("LoginViewController")]
	partial class LoginViewController
	{
		[Outlet]
		UIKit.UILabel clickToRegister { get; set; }

		[Outlet]
		UIKit.UITextField emailText { get; set; }

		[Outlet]
		UIKit.UIButton loginButton { get; set; }

		[Outlet]
		UIKit.UIView overlay { get; set; }

		[Outlet]
		UIKit.UITextField passwordText { get; set; }

		[Outlet]
		UIKit.UIView progressBar { get; set; }

		[Outlet]
		UIKit.UILabel progressStatusText { get; set; }

		[Outlet]
		UIKit.UIButton testButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (clickToRegister != null) {
				clickToRegister.Dispose ();
				clickToRegister = null;
			}

			if (emailText != null) {
				emailText.Dispose ();
				emailText = null;
			}

			if (loginButton != null) {
				loginButton.Dispose ();
				loginButton = null;
			}

			if (passwordText != null) {
				passwordText.Dispose ();
				passwordText = null;
			}

			if (testButton != null) {
				testButton.Dispose ();
				testButton = null;
			}

			if (overlay != null) {
				overlay.Dispose ();
				overlay = null;
			}

			if (progressStatusText != null) {
				progressStatusText.Dispose ();
				progressStatusText = null;
			}

			if (progressBar != null) {
				progressBar.Dispose ();
				progressBar = null;
			}
		}
	}
}
