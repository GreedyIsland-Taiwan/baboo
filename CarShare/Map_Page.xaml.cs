using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CarShare
{
	public partial class Map_Page : ContentPage
	{
		public Map_Page()
		{
			InitializeComponent();
		}

		void OnTapGestureRecognizerTapped(object sender, EventArgs args)
		{
			//var imageSender = (Image)sender;
			// Do something
			//DisplayAlert("Alert", "Tap gesture recoganised", "OK");

			//進到下一頁
			var newPage = new NavigationPage(new Car_Owner_Page());
			Navigation.PushModalAsync(newPage);
			//PushAsync = 到下一頁，有 Back 按鈕
			//PushModalAsync =  到下一頁，沒有 Back 按鈕
		}
	}
}
