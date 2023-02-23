using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Numerics;
using System.Text;
using Basketball;

namespace Basketball
{
    public class Team
    {
        private List<Player> players;
        public Team(string name, int openPositions, char group)
        {
            Name = name;
            OpenPositions = openPositions;
            Group = group;
            this.players = new List<Player>();
        }

        public string Name { get; set; }
        public int OpenPositions { get; set; }
        public char Group { get; set; }
        public IReadOnlyCollection<Player> Players => this.players;
        public int Count => this.Players.Count;
        public string  AddPlayer(Player players)
        {
            if(players.Name==null && players.Name==string.Empty
                && players.Position==null && players.Position==string.Empty)
            {
                return "Invalid player's information.";
            }
            if(OpenPositions==0)
            {
                return "There are no more open positions.";
            }
            if(players.Rating<80)
            {
                return "Invalid player's rating.";
            }
            
            this.players.Add(players);
            OpenPositions--;
            return $"Successfully added {players.Name} to the team. Remaining open positions: {OpenPositions}.";
        }
        public bool RemovePlayer(string name)
        {
            for (int i = 0; i < this.Players.Count; i++)
            {
                if (players[i].Name==name)
                {
                    players.RemoveAt(i);
                    OpenPositions++;
                    return true;
                }
            }
            return false;
        }
        public int RemovePlayerByPosition(string position)

        {
            int count = 0;
            for (int i = 0; i < Players.Count; i++)
            {
                if (players[i].Position==position)
                {
                    players.Remove(players[i]);
                    OpenPositions--;
                    count++;
                }
                
            }
            return count;
        }
        public Player RetirePlayer(string name)
        {
            var targetPlayer = this.Players.FirstOrDefault(x => x.Name == name);
            if (targetPlayer == null)
            {
                return null;
            }
            targetPlayer.Retired = true;
            return targetPlayer;
        }
       
        
        public List<Player> AwardPlayers(int games) => this.Players.Where(p => p.Games >= games).ToList();

        public string Report()

        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Active players competing for Team {Name} from Group {Group}:");
            List<Player> players = this.Players.Where(p => p.Retired == false).ToList();
           sb.AppendLine(string.Join(Environment.NewLine, players));

            return sb.ToString().Trim();
        }
       
    }
}
