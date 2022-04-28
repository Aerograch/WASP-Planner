using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WASP_Planner
{
    class Response_my
    {
        List<Player> players;
        [JsonPropertyName("players")]
        public List<Player> Players { get { return players; } set { players = value; } }
    }
}
