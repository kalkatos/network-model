namespace Kalkatos.Network.Model
{
	public class UserInfo
	{
		public string Name;
		public string Email;
		public string Picture;
		public string UserId;

		public UserInfo () { }

		public UserInfo (UserInfo other)
		{
			Name = other.Name;
			Email = other.Email;
			Picture = other.Picture;
			UserId = other.UserId;
		}
	}
}
