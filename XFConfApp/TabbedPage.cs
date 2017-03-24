using System;

using Xamarin.Forms;

namespace XFConfApp
{
	public class TabbedPage : ContentPage
	{
		public TabbedPage()
		{
			Content = new StackLayout
			{
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}

