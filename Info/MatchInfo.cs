using System.Collections.Generic;

namespace Kalkatos.Network.Model
{
	public class MatchInfo
	{
		public string MatchId;
		public string Alias;
		public PlayerInfo[] Players;
		public bool IsStarted;
		public bool IsEnded;
		public Dictionary<string, string> Settings;
		public Dictionary<string, string> CustomData;
		public StateInfo State;
	}
}