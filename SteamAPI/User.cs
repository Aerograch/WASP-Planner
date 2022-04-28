using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http.Headers;
using WASP_Planner.SteamAPI.Token;

namespace WASP_Planner
{
    public class User
    {
        static readonly HttpClient client = new HttpClient();
        string id;
        Response_all response;
        FriendsList response_friends;
        
        public User(string id)
        {
            this.id = id;
            Update().GetAwaiter().GetResult();
        }

        public string Id { get { return id; } set { id = value; } } 


        public static readonly JsonSerializerOptions options = new JsonSerializerOptions
        {
            MaxDepth = 16
        };
        
        

        public string Game
        {
            get
            {
                client.DefaultRequestHeaders.Add("User-Agent", "Accept");
                // Call asynchronous network methods in a try/catch block to handle exceptions.
                if (response != null)
                {
                    return response.Response.Players[0].Gameextrainfo;
                }
                return null;
            }
        }

        public int? Communityvisibilitystate
        {
            get
            {
                client.DefaultRequestHeaders.Add("User-Agent", "Accept");
                // Call asynchronous network methods in a try/catch block to handle exceptions.
                if (response != null)
                {
                    return response.Response.Players[0].Communityvisibilitystate;
                }
                return null;
            }
        }

        public int? Profilestate
        {
            get
            {
                client.DefaultRequestHeaders.Add("User-Agent", "Accept");
                // Call asynchronous network methods in a try/catch block to handle exceptions.
                if (response != null)
                {
                    return response.Response.Players[0].Profilestate;
                }
                return null;
            }
        }

        public string Personaname
        {
            get
            {
                client.DefaultRequestHeaders.Add("User-Agent", "Accept");
                // Call asynchronous network methods in a try/catch block to handle exceptions.
                if (response != null)
                {
                    return response.Response.Players[0].Personaname;
                }
                return null;
            }
        }

        public int? Commentpermission
        {
            get
            {
                client.DefaultRequestHeaders.Add("User-Agent", "Accept");
                // Call asynchronous network methods in a try/catch block to handle exceptions.
                if (response != null)
                {
                    return response.Response.Players[0].Commentpermission;
                }
                return null;
            }
        }

        public string Profileurl
        {
            get
            {
                client.DefaultRequestHeaders.Add("User-Agent", "Accept");
                // Call asynchronous network methods in a try/catch block to handle exceptions.
                if (response != null)
                {
                    return response.Response.Players[0].Profileurl;
                }
                return null;
            }
        }

        public string Avatar
        {
            get
            {
                client.DefaultRequestHeaders.Add("User-Agent", "Accept");
                // Call asynchronous network methods in a try/catch block to handle exceptions.
                if (response != null)
                {
                    return response.Response.Players[0].Avatar;
                }
                return null;
            }
        }

        public string Avatarfull
        {
            get
            {
                client.DefaultRequestHeaders.Add("User-Agent", "Accept");
                // Call asynchronous network methods in a try/catch block to handle exceptions.
                if (response != null)
                {
                    return response.Response.Players[0].Avatarfull;
                }
                return null;
            }
        }

        public string Avatarhash
        {
            get
            {
                client.DefaultRequestHeaders.Add("User-Agent", "Accept");
                // Call asynchronous network methods in a try/catch block to handle exceptions.
                if (response != null)
                {
                    return response.Response.Players[0].Avatarhash;
                }
                return null;
            }
        }

        public long? Lastlogoff
        {
            get
            {
                client.DefaultRequestHeaders.Add("User-Agent", "Accept");
                // Call asynchronous network methods in a try/catch block to handle exceptions.
                if (response != null)
                {
                    return response.Response.Players[0].Lastlogoff;
                }
                return null;
            }
        }

        public int? Personastate
        {
            get
            {
                client.DefaultRequestHeaders.Add("User-Agent", "Accept");
                // Call asynchronous network methods in a try/catch block to handle exceptions.
                if (response != null)
                {
                    return response.Response.Players[0].Personastate;
                }
                return null;
            }
        }

        public string Primaryclanid
        {
            get
            {
                client.DefaultRequestHeaders.Add("User-Agent", "Accept");
                // Call asynchronous network methods in a try/catch block to handle exceptions.
                if (response != null)
                {
                    return response.Response.Players[0].Primaryclanid;
                }
                return null;
            }
        }

        public long? Timecreated
        {
            get
            {
                client.DefaultRequestHeaders.Add("User-Agent", "Accept");
                // Call asynchronous network methods in a try/catch block to handle exceptions.
                if (response != null)
                {
                    return response.Response.Players[0].Timecreated;
                }
                return null;
            }
        }

        public int? Personastateflags
        {
            get
            {
                client.DefaultRequestHeaders.Add("User-Agent", "Accept");
                // Call asynchronous network methods in a try/catch block to handle exceptions.
                if (response != null)
                {
                    return response.Response.Players[0].Personastateflags;
                }
                return null;
            }
        }

        public string Loccountrycode
        {
            get
            {
                client.DefaultRequestHeaders.Add("User-Agent", "Accept");
                // Call asynchronous network methods in a try/catch block to handle exceptions.
                if (response != null)
                {
                    return response.Response.Players[0].Loccountrycode;
                }
                return null;
            }
        }

        public string Realname
        {
            get
            {
                client.DefaultRequestHeaders.Add("User-Agent", "Accept");
                // Call asynchronous network methods in a try/catch block to handle exceptions.
                if (response != null)
                {
                    return response.Response.Players[0].Realname;
                }
                return null;
            }
        }

        public string Gameid
        {
            get
            {
                client.DefaultRequestHeaders.Add("User-Agent", "Accept");
                // Call asynchronous network methods in a try/catch block to handle exceptions.
                if (response != null)
                {
                    return response.Response.Players[0].Gameid;
                }
                return null;
            }
        }

        public string Locstatecode
        {
            get
            {
                client.DefaultRequestHeaders.Add("User-Agent", "Accept");
                // Call asynchronous network methods in a try/catch block to handle exceptions.
                if (response != null)
                {
                    return response.Response.Players[0].Locstatecode;
                }
                return null;
            }
        }

        public int? Loccityid
        {
            get
            {
                client.DefaultRequestHeaders.Add("User-Agent", "Accept");
                // Call asynchronous network methods in a try/catch block to handle exceptions.
                if (response != null)
                {
                    return response.Response.Players[0].Loccityid;
                }
                return null;
            }
        }

        public List<string> Friends_ids
        {
            get
            {
                List<String> result = new List<string>();
                client.DefaultRequestHeaders.Add("User-Agent", "Accept");
                // Call asynchronous network methods in a try/catch block to handle exceptions.
                if (response_friends != null)
                {
                    foreach (Friend i in response_friends.Response.Friend)
                    {
                        result.Add(i.Steamid);
                    }
                    return result;
                }
                return null;
            }
        }

        public async Task Update()
        {
            this.response_friends = await Processing_friends($"https://api.steampowered.com/ISteamUser/GetFriendList/v1?key={Token.Key}&steamid=" + this.Id); ;
            this.response = await Processing($"https://api.steampowered.com/ISteamUser/GetPlayerSummaries/v2/?key={Token.Key}&format=json&steamids=" + this.id);
        }

        private static async Task<Response_all> Processing(string request)
        {
            //HttpResponseMessage response = await client.GetAsync($"https://api.steampowered.com/ISteamUser/GetPlayerSummaries/v2/?key={Token.Key}&format=json&steamids=76561199118366408");

            HttpResponseMessage response = await client.GetAsync(request);

            if (response.IsSuccessStatusCode)
            {
                var responseBody = response.Content.ReadAsStreamAsync();
                var result = await JsonSerializer.DeserializeAsync<Response_all>(await responseBody, options);
                return result;
            }
            else
            {
                Console.WriteLine(response.StatusCode);
            }
            return null;
        }

        private static async Task<FriendsList> Processing_friends(string request)
        {
            //HttpResponseMessage response = await client.GetAsync($"https://api.steampowered.com/ISteamUser/GetPlayerSummaries/v2/?key={Token.Key}&format=json&steamids=76561199118366408");

            HttpResponseMessage response = await client.GetAsync(request);

            if (response.IsSuccessStatusCode)
            {
                var responseBody = response.Content.ReadAsStreamAsync();
                var result = await JsonSerializer.DeserializeAsync<FriendsList>(await responseBody, options);
                return result;
            }
            else
            {
                Console.WriteLine(response.StatusCode);
            }
            return null;
        }
    }
}
