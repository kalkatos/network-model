using System;

namespace FunctionsGame.NetworkModel
{
	public class PlayerRegistry
	{
		public string PlayerId;
		public bool IsAuthenticated;
		public string[] Devices;
		public DateTime LastAccess;
		public DateTime FirstAccess;
		public DateTime TimeOfAuthentication;
	}
}
