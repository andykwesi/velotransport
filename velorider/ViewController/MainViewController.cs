// This file has been autogenerated from a class added in the UI designer.

using System;
using UIKit;

namespace velorider
{
    public partial class MainViewController : UIViewController
	{
		public MainViewController (IntPtr handle) : base (handle)
		{
		}
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            ApplyStylesToView();
        }
        void ApplyStylesToView()
        {
            locationBar.Layer.ShadowOpacity = 0.2f;
            locationBar.Layer.ShadowRadius = 5;
            locationBar.Layer.BorderWidth = 1;
            locationBar.Layer.BorderColor = UIColor.FromRGB(193, 193, 193).CGColor;


            favoritePlacesButton.Layer.ShadowOpacity = 0.2f;
            favoritePlacesButton.Layer.ShadowRadius = 5;
        }
    }

}
