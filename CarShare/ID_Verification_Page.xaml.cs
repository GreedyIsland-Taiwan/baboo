using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CarShare
{
	public partial class ID_Verification_Page : ContentPage
	{
		public ID_Verification_Page()
		{
			InitializeComponent();
		}

		void Submit_Button_Clicked(object sender, System.EventArgs e)
		{
			//進到下一頁
			var newPage = new Map_Page();
			Navigation.PushModalAsync(newPage);
			//PushAsync = 到下一頁，有 Back 按鈕
			//PushModalAsync =  到下一頁，沒有 Back 按鈕
		}
	}
}
