using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Linq;

namespace XFConfApp
{
	public class FavoritesViewModel
	{
		ObservableCollection<Session> favorites;

		public FavoritesViewModel()
		{
			favorites = new ObservableCollection<Session>();
			MessagingCenter.Subscribe<SessionsPage, Session>(this, "Favorites", (sender, args) =>
			{
				favorites.Add(args);
			});
		}

		public ObservableCollection<Session> Favorites
		{
			get { return favorites; }
			set { favorites = value; }
		}

		public bool IsFavoritesAvailable
		{
			get
			{
				if (favorites != null)
				{
					return favorites.Any();
				}
				else
				{
					return false;
				}
			}
		}

	}
}
