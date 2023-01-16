// WARNING
//
// This file has been generated automatically by Rider IDE
//   to store outlets and actions made in Xcode.
// If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Native.CodeSample.iOS.Views.Second.ItemCell
{
	partial class ItemCell
	{
		[Outlet]
		UIKit.UILabel FirstLabel { get; set; }

		[Outlet]
		UIKit.UIImageView Picture { get; set; }

		[Outlet]
		UIKit.UILabel SecondLabel { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (FirstLabel != null) {
				FirstLabel.Dispose ();
				FirstLabel = null;
			}

			if (SecondLabel != null) {
				SecondLabel.Dispose ();
				SecondLabel = null;
			}

			if (Picture != null) {
				Picture.Dispose ();
				Picture = null;
			}

		}
	}
}
