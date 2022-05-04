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
	[Register ("PersonalInfoViewController")]
	partial class PersonalInfoViewController
	{
		[Outlet]
		AppKit.NSTextField adressTextField { get; set; }

		[Outlet]
		AppKit.NSTextField cardNumberTextField { get; set; }

		[Outlet]
		AppKit.NSTextField cvcTextField { get; set; }

		[Outlet]
		AppKit.NSDatePicker dateCardDatePicker { get; set; }

		[Outlet]
		AppKit.NSTextField phoneNumberTextField { get; set; }

		[Outlet]
		AppKit.NSTextField summTextField { get; set; }

		[Action ("payClicked:")]
		partial void payClicked (AppKit.NSButton sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (adressTextField != null) {
				adressTextField.Dispose ();
				adressTextField = null;
			}

			if (cardNumberTextField != null) {
				cardNumberTextField.Dispose ();
				cardNumberTextField = null;
			}

			if (dateCardDatePicker != null) {
				dateCardDatePicker.Dispose ();
				dateCardDatePicker = null;
			}

			if (cvcTextField != null) {
				cvcTextField.Dispose ();
				cvcTextField = null;
			}

			if (phoneNumberTextField != null) {
				phoneNumberTextField.Dispose ();
				phoneNumberTextField = null;
			}

			if (summTextField != null) {
				summTextField.Dispose ();
				summTextField = null;
			}
		}
	}
}
