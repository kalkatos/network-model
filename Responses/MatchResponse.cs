using System.Collections.Generic;

namespace Kalkatos.Network.Model
{
	public class MatchResponse : Response
	{
		public string MatchId;
		public string Alias;
		public PlayerInfo[] Players;
		public bool IsOver;
        public bool IsStarted;
    }
}
