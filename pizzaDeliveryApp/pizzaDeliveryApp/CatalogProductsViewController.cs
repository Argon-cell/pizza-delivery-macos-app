using System;
using Foundation;
using AppKit;
using pizzaDeliveryApp.Models;

namespace pizzaDeliveryApp
{
	public partial class CatalogProductsViewController : NSViewController
	{
		//Variables
		//private DataBase DBObject = new DataBase();

		//Events
		public CatalogProductsViewController(IntPtr handle) : base(handle)
		{
		}

		//StartMethod
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			//DBObject.OpenConnection();
		}

		//SeguesControll
		public override void PrepareForSegue(NSStoryboardSegue segue, NSObject sender)
		{
			base.PrepareForSegue(segue, sender);

			if (segue.Identifier != "Orders" && segue.Identifier != "Basket")
			{
				CountChoiceViewController target = segue.DestinationController as CountChoiceViewController;
				target.nameProduct = segue.Identifier;
			}
		}
	}
}
