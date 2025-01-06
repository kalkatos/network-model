namespace Kalkatos.Network.Model
{
	public class LoginRequest
	{
		public string Identifier;
		public string DeviceId;
		public string GameId;
		public string Region;
		public bool MustAuthenticate;
	}
}
