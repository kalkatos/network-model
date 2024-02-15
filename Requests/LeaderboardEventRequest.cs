using System.Collections.Generic;

namespace Kalkatos.Network.Model
{
    public class LeaderboardEventRequest
    {
        public string GameId;
        public string PlayerId;
        public string Key;
        public double Value;
        public Dictionary<string, string> CustomData;
    }
}
