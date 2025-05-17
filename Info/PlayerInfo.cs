using System.Collections.Generic;

namespace Kalkatos.Network.Model
{
	public class PlayerInfo
	{
		public string Alias;
		public string Nickname;
		public Dictionary<string, string> CustomData;

		public bool IsBot
		{
			get
			{
				if (string.IsNullOrEmpty(Alias))
					return false;
				return Alias[0] == 'X';
			}
		}

		public PlayerInfo Clone ()
		{
			Dictionary<string, string> newCustomData = new Dictionary<string, string>();
			if (CustomData != null)
			{
				foreach (var item in CustomData)
					newCustomData.Add(item.Key, item.Value);
			}
			return new PlayerInfo
			{
				Alias = Alias,
				Nickname = Nickname,
				CustomData = newCustomData
			};
		}

		public override bool Equals (object obj)
		{
			if (base.Equals(obj))
				return true;
			if (ReferenceEquals(this, null))
				return false;
			if (ReferenceEquals(obj, null))
				return false;
			if (obj is not PlayerInfo)
				return false;
			return Alias.Equals(((PlayerInfo)obj).Alias);
		}

		public override int GetHashCode ()
		{
			return Alias.GetHashCode();
		}
	}
}