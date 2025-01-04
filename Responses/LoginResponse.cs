namespace Kalkatos.Network.Model
{
	public class LoginResponse : Response
	{
		public bool IsAuthenticated;
		public string PlayerId;
		public PlayerInfo MyInfo;
	}
}
