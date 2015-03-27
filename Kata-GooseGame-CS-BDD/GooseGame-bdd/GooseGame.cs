using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GooseGame_bdd
{
    public class GooseGame
    {
        private List<string> players;

        public GooseGame()
        {
            players = new List<string>();
        }

        public void AddPlayer(string player)
        {
            if (players.Contains(player))
            {
                LastMessage = string.Format("{0} already present", player);
            }
            else
            {
                players.Add(player);
                LastMessage = string.Format("Players: {0}", string.Join(", ", players.ToArray()));
            }
        }

        public string LastMessage { get; set; }
    }
}
