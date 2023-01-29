namespace Kalkatos.Network.Model
{
	public class PlayerInfo
	{
		public string Alias;
		public string Nickname;
		public string[] CustomData;

		public PlayerInfo Clone ()
		{
			string[] newCustomData = null;
			if (CustomData != null)
			{
				newCustomData = new string[CustomData.Length];
				for (int i = 0; i < CustomData.Length; i++)
					newCustomData[i] = CustomData[i];
			}
			return new PlayerInfo
			{
				Alias = Alias,
				Nickname = Nickname,
				CustomData = newCustomData
			};
		}
	}
}