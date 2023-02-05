using System.Collections.Generic;

namespace Kalkatos.Network.Model
{
	public class ActionRequest
	{
		public string PlayerId;
		public string PlayerAlias;
		public string MatchId;
		public Dictionary<string, string> Content;
		public string ActionName;
		public string SerializedParameter;
	}
}
