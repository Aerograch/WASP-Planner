using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;


namespace WASP_Planner
{
    class FriendsList
    {
        Friends friends;
        [JsonPropertyName("friendslist")]
        public Friends Response { get { return friends; } set { friends = value; } }
    }
}
