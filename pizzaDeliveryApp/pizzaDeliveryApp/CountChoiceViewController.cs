using System;
using AppKit;
using pizzaDeliveryApp.Models;
using System.Data.SqlClient;

namespace pizzaDeliveryApp
{
	public partial class CountChoiceViewController : NSViewController
	{
		//Varibales
		public string nameProduct { get; set; }
		private DataBase DBObject = new DataBase();
		private Products product;

		//StartMethods
		public CountChoiceViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad()
		{
			Console.WriteLine(1);
			base.ViewDidLoad();
			DBObject.OpenConnection();
		}


		//Buttons
		partial void addClicked(NSButton sender)
		{
			addToBasket(nameProduct);
		}

		//ButtonsMetods
		private void addToBasket(string nameProduct)
		{
			var storyboard = NSStoryboard.FromName("Main", null);

			if (Convert.ToInt32(countTextField.StringValue) <= 0)
			{
				var controller = storyboard.InstantiateControllerWithIdentifier("CountLessThan1") as NSViewController;
				PresentViewControllerAsSheet(controller);
			}
			else
			{
				string commandString = string.Format("SELECT * FROM Products WHERE Name = N'{0}'", nameProduct);
				SqlCommand command = new SqlCommand(commandString, DBObject.connection);

				using (SqlDataReader reader = command.ExecuteReader())
				{
					reader.Read();
					product = new Products() { Name = reader[1].ToString(), Price = Convert.ToInt32(reader[3].ToString()) };
				}

				string insertCommand = string.Format("INSERT INTO Basket VALUES (N'{0}', {1}, {2})", product.Name, Convert.ToInt32(countTextField.StringValue), product.Price * Convert.ToInt32(countTextField.StringValue));
				command = new SqlCommand(insertCommand, DBObject.connection);
				command.ExecuteNonQuery();

				var catalogProducts = storyboard.InstantiateControllerWithIdentifier("AddedProduct") as NSViewController;
				PresentViewControllerAsSheet(catalogProducts);

			}
		}
	}
}
