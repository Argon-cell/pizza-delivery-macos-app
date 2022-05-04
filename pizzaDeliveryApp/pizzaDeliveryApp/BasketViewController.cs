using System;
using AppKit;
using System.Collections.Generic;
using pizzaDeliveryApp.Models;
using System.Data.SqlClient;

namespace pizzaDeliveryApp
{
	public partial class BasketViewController : NSViewController
	{
		//Variables
		private DataBase DBObject = new DataBase();


		//Events
		public BasketViewController (IntPtr handle) : base (handle)
		{
		}


		//Classes
		public class BasketTableDataSource : NSTableViewDataSource
		{
			public List<Basket> BasketElements = new List<Basket>();

			public BasketTableDataSource()
			{
			}

			public override nint GetRowCount(NSTableView tableView)
			{
				return BasketElements.Count;
			}
		}

		public class BasketTableDelegate : NSTableViewDelegate
		{
			private const string CellIdentifier = "BasketCell";
			private BasketTableDataSource DataSource;

			public BasketTableDelegate(BasketTableDataSource datasource)
			{
				this.DataSource = datasource;
			}

			public override NSView GetViewForItem(NSTableView tableView, NSTableColumn tableColumn, nint row)
			{
				NSTextField view = (NSTextField)tableView.MakeView(CellIdentifier, this);

				if (view == null)
				{
					view = new NSTextField();
					view.Identifier = CellIdentifier;
					view.BackgroundColor = NSColor.Clear;
					view.Bordered = false;
					view.Selectable = false;
					view.Editable = false;
				}

				switch (tableColumn.Title)
				{
					case "Пиццы":
						view.StringValue = DataSource.BasketElements[(int)row].NameProduct.ToString();
						break;

					case "Количество":
						view.StringValue = DataSource.BasketElements[(int)row].CountProduct.ToString();
						break;

					case "Сумма":
						view.StringValue = DataSource.BasketElements[(int)row].Amount.ToString();
						break;
				}

				return view;
			}
		}


		//StartMethod
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			var DataSource = new BasketTableDataSource();
			SqlCommand command = new SqlCommand("SELECT * FROM Basket", DBObject.connection);

			DBObject.OpenConnection();

			using (SqlDataReader reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					Basket basket = new Basket();

					basket.Id = Convert.ToInt32(reader[0].ToString());
					basket.NameProduct = reader[1].ToString();
					basket.CountProduct = Convert.ToInt32(reader[2].ToString());
					basket.Amount = Convert.ToInt32(reader[3].ToString());

					DataSource.BasketElements.Add(basket);
				}

				basketTableView.DataSource = DataSource;
				basketTableView.Delegate = new BasketTableDelegate(DataSource);
			}
		}


		//Buttons
		partial void clearBasketClicked(NSButton sender)
		{
			clearBasket();
		}


		//MethodsForButtons
		private void clearBasket()
		{
			SqlCommand deleteCommand = new SqlCommand("DELETE FROM Basket", DBObject.connection);
			deleteCommand.ExecuteNonQuery();

			var DataSource = new BasketTableDataSource();

			basketTableView.DataSource = DataSource;
			basketTableView.Delegate = new BasketTableDelegate(DataSource);
		}

	}
}
