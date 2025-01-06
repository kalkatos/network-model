namespace Kalkatos.Network.Model
{
	public class LoginResponse : Response
	{
		public bool IsAuthenticated;
		public string PlayerId;
		public PlayerInfo MyInfo;
	}
	
	public class UrlLoginResponse : LoginResponse
	{
		public string AuthUrl;
	}

	public class AuthLoginResponse : LoginResponse
	{
		public UserInfo UserInfo;
	}
}
