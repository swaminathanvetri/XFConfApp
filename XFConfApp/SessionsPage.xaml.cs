using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFConfApp
{
	public partial class SessionsPage : ContentPage
	{
		SessionsViewModel viewModel;
		public SessionsPage()
		{
			InitializeComponent();
			viewModel = new SessionsViewModel();
			sessionsListView.ItemsSource = viewModel.SessionsByTimings;
		}

		public void OnFavorites(object sender, EventArgs e)
		{
			var mi = (MenuItem)sender;
			MessagingCenter.Send<SessionsPage, Session>(this, "Favorites", (Session)mi.CommandParameter);
			DisplayAlert("More Context Action", mi.CommandParameter + " favorite clicked", "OK");
		}
	}
}
