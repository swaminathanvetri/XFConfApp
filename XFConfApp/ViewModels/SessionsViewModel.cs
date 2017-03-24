using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace XFConfApp
{
	public class SessionsViewModel
	{
		ObservableCollection<Session> sessions;
		public SessionsViewModel()
		{
			sessions = new ObservableCollection<Session>
			{
				new Session { Speaker ="Swaminathan Vetri", Topic ="Designing Xamarin Forms apps", Time="09:00-10:00",Venue="Hall 1"},
				new Session { Speaker ="Swami", Topic ="Debugging Xamarin Forms apps", Time="09:00-10:00",Venue="Hall 2"},
				new Session { Speaker ="Safil Sunny", Topic ="Developing Xamarin Forms apps", Time="10:00-11:00",Venue="Hall 1"},
				new Session { Speaker ="Safil", Topic ="Testing Xamarin Forms apps", Time="10:00-11:00",Venue="Hall 2"}
			};
		}

		public ObservableCollection<Session> Sessions
		{
			get { return sessions; }
			set { sessions = value; }
		}

		public ObservableCollection<SessionsByTiming> SessionsByTimings
		{
			get { return GroupSessionsByTiming(); }
		}

		private ObservableCollection<SessionsByTiming> GroupSessionsByTiming()
		{
			ObservableCollection<SessionsByTiming> sessionsByTimingList = new ObservableCollection<SessionsByTiming>();
			var group = sessions.GroupBy(session => session.Time);
			foreach (var item in group)
			{
				var sessionsInGroup = item.ToList();
				var groupedData = new SessionsByTiming(item.Key);
				foreach (var session in sessionsInGroup)
				{
					groupedData.Add(session);
				}
				sessionsByTimingList.Add(groupedData);
			}
			return sessionsByTimingList;
		}
	}

	public class SessionsByTiming : ObservableCollection<Session>
	{
		public string Timing
		{
			get;
			private set;
		}
		public SessionsByTiming(string timing)
		{
			Timing = timing;
		}
	}
}
