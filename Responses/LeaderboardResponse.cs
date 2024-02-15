namespace Kalkatos.Network.Model
{
    public class LeaderboardResponse : Response
    {
        public LeaderboardPlayerInfo[] Leaderboard;
        public string NextPageId;
    }
}
