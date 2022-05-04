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
	[Register ("CountChoiceViewController")]
	partial class CountChoiceViewController
	{
		[Outlet]
		AppKit.NSTextField countTextField { get; set; }

		[Action ("addClicked:")]
		partial void addClicked (AppKit.NSButton sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (countTextField != null) {
				countTextField.Dispose ();
				countTextField = null;
			}
		}
	}
}
