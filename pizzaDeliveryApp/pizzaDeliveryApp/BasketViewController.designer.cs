// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace pizzaDeliveryApp
{
	[Register ("BasketViewController")]
	partial class BasketViewController
	{
		[Outlet]
		AppKit.NSTableView basketTableView { get; set; }

		[Action ("clearBasketClicked:")]
		partial void clearBasketClicked (AppKit.NSButton sender);

		[Action ("createOrderClicked:")]
		partial void createOrderClicked (AppKit.NSButton sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (basketTableView != null) {
				basketTableView.Dispose ();
				basketTableView = null;
			}
		}
	}
}
