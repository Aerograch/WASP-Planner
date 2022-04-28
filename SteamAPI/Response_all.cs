using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WASP_Planner
{
    class Response_all
    {
        Response_my response;
        [JsonPropertyName("response")]
        public Response_my Response { get { return response; } set { response = value; } }
    }
}
