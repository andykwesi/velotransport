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
	[Register ("RegisterViewController")]
	partial class RegisterViewController
	{
		[Outlet]
		UIKit.UILabel clickToLogin { get; set; }

		[Outlet]
		UIKit.UITextField emailText { get; set; }

		[Outlet]
		UIKit.UITextField fullnameText { get; set; }

		[Outlet]
		UIKit.UIView overlay { get; set; }

		[Outlet]
		UIKit.UITextField passwordText { get; set; }

		[Outlet]
		UIKit.UITextField phoneText { get; set; }

		[Outlet]
		UIKit.UIView progressBar { get; set; }

		[Outlet]
		UIKit.UILabel progressStatusText { get; set; }

		[Outlet]
		UIKit.UIButton registerButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (clickToLogin != null) {
				clickToLogin.Dispose ();
				clickToLogin = null;
			}

			if (emailText != null) {
				emailText.Dispose ();
				emailText = null;
			}

			if (fullnameText != null) {
				fullnameText.Dispose ();
				fullnameText = null;
			}

			if (overlay != null) {
				overlay.Dispose ();
				overlay = null;
			}

			if (passwordText != null) {
				passwordText.Dispose ();
				passwordText = null;
			}

			if (phoneText != null) {
				phoneText.Dispose ();
				phoneText = null;
			}

			if (progressBar != null) {
				progressBar.Dispose ();
				progressBar = null;
			}

			if (registerButton != null) {
				registerButton.Dispose ();
				registerButton = null;
			}

			if (progressStatusText != null) {
				progressStatusText.Dispose ();
				progressStatusText = null;
			}
		}
	}
}
