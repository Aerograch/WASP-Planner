using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace WASP_Planner
{
    class Friend
    {
        [JsonPropertyName("steamid")]
        public string Steamid { get; set; }

        [JsonPropertyName("relationship")]
        public string Relationship { get; set; }

        [JsonPropertyName("friend_since")]
        public long Friend_since { get; set; }
    }
}
