// WARNING
//
// This file has been generated automatically by Rider IDE
//   to store outlets and actions made in Xcode.
// If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Native.CodeSample.iOS.Views.Second.SecondTab
{
	partial class SecondTabViewController
	{
		[Outlet]
		UIKit.UIButton AddButton { get; set; }

		[Outlet]
		UIKit.UITableView ItemsTable { get; set; }

		[Outlet]
		UIKit.UIButton RemoveFirstButton { get; set; }

		[Outlet]
		UIKit.UISwitch Switch { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (Switch != null) {
				Switch.Dispose ();
				Switch = null;
			}

			if (AddButton != null) {
				AddButton.Dispose ();
				AddButton = null;
			}

			if (RemoveFirstButton != null) {
				RemoveFirstButton.Dispose ();
				RemoveFirstButton = null;
			}

			if (ItemsTable != null) {
				ItemsTable.Dispose ();
				ItemsTable = null;
			}

		}
	}
}
