using System;
using System.Collections.Generic;
using Foundation;
using AppKit;
using pizzaDeliveryApp.Models;
using System.Data.SqlClient;

namespace pizzaDeliveryApp
{
	public partial class PersonalInfoViewController : NSViewController
	{
		//Methods
		public NSDate ToNsDate(DateTime dateTime)
		{
			if (dateTime.Kind == DateTimeKind.Unspecified)
			{
				dateTime = DateTime.SpecifyKind(dateTime, DateTimeKind.Local);
			}
			return (NSDate)dateTime;
		}

		public DateTime ToDateTime(NSDate date)
		{
			NSCalendar calendar = new NSCalendar(NSCalendarType.Gregorian) { TimeZone = NSTimeZone.FromGMT(NSTimeZone.LocalTimeZone.GetSecondsFromGMT) };
			NSDateComponents components = calendar.Components(NSCalendarUnit.Year | NSCalendarUnit.Month | NSCalendarUnit.Day | NSCalendarUnit.Hour | NSCalendarUnit.Minute | NSCalendarUnit.Second | NSCalendarUnit.Calendar, date);

			return new DateTime((int)components.Year, (int)components.Month, (int)components.Day, (int)components.Hour, (int)components.Minute, (int)components.Second);
		}


		//Variables
		List<String> products = new List<string>();
		private int summ = 0;
		private DataBase DBObject = new DataBase();


		//Events
		public PersonalInfoViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			DBObject.OpenConnection();
			SqlCommand command = new SqlCommand("SELECT * FROM Basket", DBObject.connection);

			using (SqlDataReader reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					products.Add(reader[1].ToString() + " x " + reader[2].ToString());
					summ += Convert.ToInt32(reader[3].ToString());
				}
			}

			summTextField.StringValue = String.Format("Итого к оплате: {0} руб.", summ);
		}


		//Buttons and their actions
		partial void payClicked(NSButton sender)
		{
			createOrder();
		}

		private void createOrder()
		{
			if (summ > 0)
			{
				string insertCommand = string.Format("INSERT INTO Orders VALUES (N'{0}', N'{1}', {2}, {3}, '{4}', {5}, {6})", string.Join(", ", products), adressTextField.StringValue, phoneNumberTextField.StringValue, cardNumberTextField.StringValue, ToDateTime(dateCardDatePicker.DateValue), cvcTextField.StringValue, summ);
				SqlCommand command = new SqlCommand(insertCommand, DBObject.connection);
				command.ExecuteNonQuery();

				string deleteCommand = string.Format("DELETE FROM Basket");
				command = new SqlCommand(deleteCommand, DBObject.connection);
				command.ExecuteNonQuery();
			}

			var storyboard = NSStoryboard.FromName("Main", null);
			var catalogProducts = storyboard.InstantiateControllerWithIdentifier("Payed") as NSViewController;
			PresentViewControllerAsSheet(catalogProducts);
		}
	}
}
