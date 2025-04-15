namespace Kalkatos.Network.Model
{
	public class NetworkError : Response
	{
		public NetworkErrorTag Tag;
		public new bool IsError = true;
	}

	public enum NetworkErrorTag
	{
		Undefined,
		NotConnected,
		WrongParameters,
		NotFound,
		NotAvailable,
		AlreadyStarted,
		IsFull,
		IsOver,
		OutdatedVersion,
	}
}