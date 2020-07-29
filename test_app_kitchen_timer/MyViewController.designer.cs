// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace test_app_kitchen_timer
{
	[Register ("MyViewController")]
	partial class MyViewController
	{
		[Outlet]
		UIKit.UIButton Add10MinButton { get; set; }

		[Outlet]
		UIKit.UIButton Add10SecButton { get; set; }

		[Outlet]
		UIKit.UIButton Add1MinButton { get; set; }

		[Outlet]
		UIKit.UIButton Add1SecButton { get; set; }

		[Outlet]
		UIKit.UIButton ClearButton { get; set; }

		[Outlet]
		UIKit.UILabel RemainingTimeLabel { get; set; }

		[Outlet]
		UIKit.UIButton StartButton { get; set; }

		[Action ("StartButton_TouchUpInside:forEvent:")]
		partial void StartButton_TouchUpInside (Foundation.NSObject sender, UIKit.UIEvent @event);
		
		void ReleaseDesignerOutlets ()
		{
			if (Add10MinButton != null) {
				Add10MinButton.Dispose ();
				Add10MinButton = null;
			}

			if (Add10SecButton != null) {
				Add10SecButton.Dispose ();
				Add10SecButton = null;
			}

			if (Add1MinButton != null) {
				Add1MinButton.Dispose ();
				Add1MinButton = null;
			}

			if (Add1SecButton != null) {
				Add1SecButton.Dispose ();
				Add1SecButton = null;
			}

			if (ClearButton != null) {
				ClearButton.Dispose ();
				ClearButton = null;
			}

			if (RemainingTimeLabel != null) {
				RemainingTimeLabel.Dispose ();
				RemainingTimeLabel = null;
			}

			if (StartButton != null) {
				StartButton.Dispose ();
				StartButton = null;
			}
		}
	}
}
