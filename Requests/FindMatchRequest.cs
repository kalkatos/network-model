﻿using System.Collections.Generic;

namespace Kalkatos.Network.Model
{
	public class FindMatchRequest
	{
		public string GameId;
		public string PlayerId;
		public string Region;
		public bool UseLobby;
		public Dictionary<string, string> CustomData;
	}
}
