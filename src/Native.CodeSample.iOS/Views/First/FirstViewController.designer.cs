// WARNING
//
// This file has been generated automatically by Rider IDE
//   to store outlets and actions made in Xcode.
// If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Native.CodeSample.iOS.Views.First
{
	partial class FirstViewController
	{
		[Outlet]
		UIKit.UIButton Button { get; set; }

		[Outlet]
		UIKit.UITextField FirstTextField { get; set; }

		[Outlet]
		UIKit.UITextField SecondTextField { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (FirstTextField != null) {
				FirstTextField.Dispose ();
				FirstTextField = null;
			}

			if (SecondTextField != null) {
				SecondTextField.Dispose ();
				SecondTextField = null;
			}

			if (Button != null) {
				Button.Dispose ();
				Button = null;
			}

		}
	}
}
