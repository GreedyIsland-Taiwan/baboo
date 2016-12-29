using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CarShare
{
	public partial class Car_Owner_Page : ContentPage
	{
		public Car_Owner_Page()
		{
			InitializeComponent();
		}

		void Switch_To_Customer_Mode_Button_Clicked(object sender, System.EventArgs e)
		{
			//進到下一頁
			var newPage = new NavigationPage(new Customer_Page());
			Navigation.PushModalAsync(newPage);
			//PushAsync = 到下一頁，有 Back 按鈕
			//PushModalAsync =  到下一頁，沒有 Back 按鈕
		}

		void Go_To_History_Button_Clicked(object sender, System.EventArgs e)
		{
			//進到下一頁
			var newPage = new NavigationPage(new History_Page());
			Navigation.PushAsync(newPage);
			//PushAsync = 到下一頁，有 Back 按鈕
			//PushModalAsync =  到下一頁，沒有 Back 按鈕
		}

		void Go_To_Add_A_Car_Page_Button_Clicked(object sender, System.EventArgs e)
		{
			//進到下一頁
			var newPage = new NavigationPage(new Add_A_Car_Page());
			Navigation.PushAsync(newPage);
			//PushAsync = 到下一頁，有 Back 按鈕
			//PushModalAsync =  到下一頁，沒有 Back 按鈕
		}
	}
}
