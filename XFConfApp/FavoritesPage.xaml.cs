using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFConfApp
{
	public partial class FavoritesPage : ContentPage
	{
		FavoritesViewModel viewModel;
		public FavoritesPage()
		{
			InitializeComponent();
			BindingContext = viewModel = new FavoritesViewModel();
		}
	}
}
