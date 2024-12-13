using System.Collections.Generic;

namespace Kalkatos.Network.Model
{
    public class PlayerInfo
    {
        public string Alias;
        public string Nickname;
        public Dictionary<string, string> CustomData;

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

        public static bool operator == (PlayerInfo a, PlayerInfo b)
        {
            return a.Equals(b);
        }

        public static bool operator != (PlayerInfo a, PlayerInfo b)
        {
            return !a.Equals(b);
        }

        public override bool Equals (object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return Alias.Equals(((PlayerInfo)obj).Alias);
        }

        public override int GetHashCode ()
        {
            return Alias.GetHashCode();
        }
    }
}