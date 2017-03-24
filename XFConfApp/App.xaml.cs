using Xamarin.Forms;

namespace XFConfApp
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			var tabbedPage = new TabbedPage
			{
				Children = {
					new NavigationPage(new FavoritesPage())
					{
						Title ="Favorites"
					},
					new NavigationPage(new SessionsPage())
					{
						Title ="Sessions"
					},
					new NavigationPage(new SpeakersPage())
					{
						Title ="Speakers"
					},
					new NavigationPage(new SponsorsPage())
					{
						Title ="Sponsors"
					},
				}
			};
			MainPage = tabbedPage;
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
