using System.Collections.Generic;
using System.Linq;

namespace Kalkatos.Network.Model
{
	public class StateInfo
	{
		public int Index;
		public Dictionary<string, string> PublicProperties;
		public Dictionary<string, string> PrivateProperties;
		public int Hash;

		public StateInfo Clone ()
		{
			StateInfo clone = new StateInfo ();
			clone.Index = Index;
			clone.PublicProperties = PublicProperties.ToDictionary(e => e.Key, e => e.Value);
			clone.PrivateProperties = PrivateProperties.ToDictionary(e => e.Key, e => e.Value);
			clone.Hash = Hash;
			return clone;
		}
	}
}
