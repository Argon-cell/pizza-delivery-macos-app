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
	[Register ("VouchersTableViewController")]
	partial class VouchersTableViewController
	{
		[Outlet]
		AppKit.NSTableColumn asIdColumn { get; set; }

		[Outlet]
		AppKit.NSTableColumn durationColumn { get; set; }

		[Outlet]
		AppKit.NSTableColumn eIdColumn { get; set; }

		[Outlet]
		AppKit.NSTableColumn endDateColumn { get; set; }

		[Outlet]
		AppKit.NSComboBox filterComboBox { get; set; }

		[Outlet]
		AppKit.NSTableColumn hIdColumn { get; set; }

		[Outlet]
		AppKit.NSTableColumn paymentMarkColumn { get; set; }

		[Outlet]
		AppKit.NSTableColumn reservationMarkColumn { get; set; }

		[Outlet]
		AppKit.NSTextField searchTextField { get; set; }

		[Outlet]
		AppKit.NSTableColumn startDateColumn { get; set; }

		[Outlet]
		AppKit.NSTableColumn tofIdColumn { get; set; }

		[Outlet]
		AppKit.NSTableView vouchersMainTableView { get; set; }

		[Action ("closeClicked:")]
		partial void closeClicked (AppKit.NSButton sender);

		[Action ("filterClicked:")]
		partial void filterClicked (AppKit.NSButton sender);

		[Action ("findClicked:")]
		partial void findClicked (AppKit.NSButton sender);

		[Action ("showClicked:")]
		partial void showClicked (AppKit.NSButton sender);

		[Action ("sortClicked:")]
		partial void sortClicked (AppKit.NSButton sender);

		[Action ("sortRadioButtons:")]
		partial void sortRadioButtons (AppKit.NSButton sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (asIdColumn != null) {
				asIdColumn.Dispose ();
				asIdColumn = null;
			}

			if (durationColumn != null) {
				durationColumn.Dispose ();
				durationColumn = null;
			}

			if (eIdColumn != null) {
				eIdColumn.Dispose ();
				eIdColumn = null;
			}

			if (endDateColumn != null) {
				endDateColumn.Dispose ();
				endDateColumn = null;
			}

			if (filterComboBox != null) {
				filterComboBox.Dispose ();
				filterComboBox = null;
			}

			if (hIdColumn != null) {
				hIdColumn.Dispose ();
				hIdColumn = null;
			}

			if (paymentMarkColumn != null) {
				paymentMarkColumn.Dispose ();
				paymentMarkColumn = null;
			}

			if (reservationMarkColumn != null) {
				reservationMarkColumn.Dispose ();
				reservationMarkColumn = null;
			}

			if (searchTextField != null) {
				searchTextField.Dispose ();
				searchTextField = null;
			}

			if (startDateColumn != null) {
				startDateColumn.Dispose ();
				startDateColumn = null;
			}

			if (tofIdColumn != null) {
				tofIdColumn.Dispose ();
				tofIdColumn = null;
			}

			if (vouchersMainTableView != null) {
				vouchersMainTableView.Dispose ();
				vouchersMainTableView = null;
			}
		}
	}
}
