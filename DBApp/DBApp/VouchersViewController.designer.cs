// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace DBApp
{
	[Register ("VouchersViewController")]
	partial class VouchersViewController
	{
		[Outlet]
		AppKit.NSTextField asIdTextField { get; set; }

		[Outlet]
		AppKit.NSTextField clientIdTextField { get; set; }

		[Outlet]
		AppKit.NSTextField durationTextField { get; set; }

		[Outlet]
		AppKit.NSDatePicker endDateDatePicker { get; set; }

		[Outlet]
		AppKit.NSTextField hIdTextField { get; set; }

		[Outlet]
		AppKit.NSComboBox payementMarkComboBox { get; set; }

		[Outlet]
		AppKit.NSComboBox reservationMarkComboBox { get; set; }

		[Outlet]
		AppKit.NSDatePicker startDateDatePicker { get; set; }

		[Outlet]
		AppKit.NSTextField tofIdTextField { get; set; }

		[Action ("DeleteClicked:")]
		partial void DeleteClicked (AppKit.NSButton sender);

		[Action ("FirstClicked:")]
		partial void FirstClicked (AppKit.NSButton sender);

		[Action ("LastClicked:")]
		partial void LastClicked (AppKit.NSButton sender);

		[Action ("NextClicked:")]
		partial void NextClicked (AppKit.NSButton sender);

		[Action ("PastClicked:")]
		partial void PastClicked (AppKit.NSButton sender);

		[Action ("SaveClicked:")]
		partial void SaveClicked (AppKit.NSButton sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (asIdTextField != null) {
				asIdTextField.Dispose ();
				asIdTextField = null;
			}

			if (clientIdTextField != null) {
				clientIdTextField.Dispose ();
				clientIdTextField = null;
			}

			if (durationTextField != null) {
				durationTextField.Dispose ();
				durationTextField = null;
			}

			if (endDateDatePicker != null) {
				endDateDatePicker.Dispose ();
				endDateDatePicker = null;
			}

			if (hIdTextField != null) {
				hIdTextField.Dispose ();
				hIdTextField = null;
			}

			if (payementMarkComboBox != null) {
				payementMarkComboBox.Dispose ();
				payementMarkComboBox = null;
			}

			if (reservationMarkComboBox != null) {
				reservationMarkComboBox.Dispose ();
				reservationMarkComboBox = null;
			}

			if (startDateDatePicker != null) {
				startDateDatePicker.Dispose ();
				startDateDatePicker = null;
			}

			if (tofIdTextField != null) {
				tofIdTextField.Dispose ();
				tofIdTextField = null;
			}
		}
	}
}
