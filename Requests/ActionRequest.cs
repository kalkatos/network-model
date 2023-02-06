using System.Collections.Generic;

namespace Kalkatos.Network.Model
{
	public class ActionRequest
	{
		public string PlayerId;
		public string MatchId;
		public Dictionary<string, string> PublicChanges;
		public Dictionary<string, string> PrivateChanges;
	}
}
