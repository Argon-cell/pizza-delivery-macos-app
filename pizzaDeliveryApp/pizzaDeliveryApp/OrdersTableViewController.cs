using System;
using AppKit;
using System.Collections.Generic;
using pizzaDeliveryApp.Models;
using System.Data.SqlClient;

namespace pizzaDeliveryApp
{
	public partial class OrdersTableViewController : NSViewController
	{
		//Variables
		private DataBase DBObject = new DataBase();


		//Classes
		public class OrdersTableDataSource : NSTableViewDataSource
		{
			public List<Orders> orders = new List<Orders>();

			public OrdersTableDataSource()
			{
			}

			public override nint GetRowCount(NSTableView tableView)
			{
				return orders.Count;
			}
		}

		public class OrdersTableDelegate : NSTableViewDelegate
		{
			private const string CellIdentifier = "OrderCell";
			private OrdersTableDataSource DataSource;

			public OrdersTableDelegate(OrdersTableDataSource datasource)
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
					view.Selectable = true;
					view.Editable = false;
				}

				switch (tableColumn.Title)
				{
					case "Пиццы":
						view.StringValue = DataSource.orders[(int)row].NameProducts.ToString();
						break;

					case "Сумма":
						view.StringValue = DataSource.orders[(int)row].Amount.ToString();
						break;

					case "Адресс":
						view.StringValue = DataSource.orders[(int)row].Adress.ToString();
						break;

					case "Контактный номер":
						view.StringValue = DataSource.orders[(int)row].NumberPhone.ToString();
						break;
				}

				return view;
			}
		}


		//StartMethods
		public OrdersTableViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			var DataSource = new OrdersTableDataSource();
			SqlCommand command = new SqlCommand("SELECT * FROM Orders", DBObject.connection);
			DBObject.OpenConnection();

			using (SqlDataReader reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					Orders order = new Orders();

					order.NameProducts = reader[1].ToString();
					order.Amount = Convert.ToInt32(reader[7].ToString());
					order.Adress = reader[2].ToString();
					order.NumberPhone = Convert.ToInt32(reader[3].ToString());

					DataSource.orders.Add(order);

				}

				ordersTableView.DataSource = DataSource;
				ordersTableView.Delegate = new OrdersTableDelegate(DataSource);
			}
		}

	}
}
