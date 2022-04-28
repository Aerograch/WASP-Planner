using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace WASP_Planner
{
    class Friends
    {
        List<Friend> friends;
        [JsonPropertyName("friends")]
        public List<Friend> Friend { get { return friends; } set { friends = value; } }
    }
}
