using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace WASP_Planner
{
    public class Player
    {
        string steamid;
        [JsonPropertyName("steamid")]
        public string Steamid { get { return steamid; } set { steamid = value; } }

        int communityvisibilitystate;
        [JsonPropertyName("communityvisibilitystate")]
        public int Communityvisibilitystate { get { return communityvisibilitystate; } set { communityvisibilitystate = value; } }

        int profilestate;
        [JsonPropertyName("profilestate")]
        public int Profilestate { get { return profilestate; } set { profilestate = value; } }

        string personaname;
        [JsonPropertyName("personaname")]
        public string Personaname { get { return personaname; } set { personaname = value; } }

        int commentpermission;
        [JsonPropertyName("commentpermission")]
        public int Commentpermission { get {return commentpermission; } set { commentpermission = value; } }

        string profileurl;
        [JsonPropertyName("profileurl")]
        public string Profileurl { get { return profileurl; } set { profileurl = value; } }

        string avatar;
        [JsonPropertyName("avatar")]
        public string Avatar { get { return avatar; } set { avatar = value; } }

        string avatarmedium;
        [JsonPropertyName("avatarmedium")]
        public string Avatarmedium { get { return avatarmedium; } set { avatarmedium = value; } }

        string avatarfull;
        [JsonPropertyName("avatarfull")]
        public string Avatarfull { get { return avatarfull; } set { avatarfull = value; } }

        string avatarhash;
        [JsonPropertyName("avatarhash")]
        public string Avatarhash { get { return avatarhash; } set { avatarhash = value; } }

        long lastlogoff;
        [JsonPropertyName("lastlogoff")]
        public long Lastlogoff { get { return lastlogoff; } set { lastlogoff = value; } }

        int personastate;
        [JsonPropertyName("personastate")]
        public int Personastate { get { return personastate; } set { personastate = value; } }

        string primaryclanid;
        [JsonPropertyName("primaryclanid")]
        public string Primaryclanid { get { return primaryclanid; } set { primaryclanid = value; } }

        long timecreated;
        [JsonPropertyName("timecreated")]
        public long Timecreated { get { return timecreated; } set { timecreated = value; } }

        int personastateflags;
        [JsonPropertyName("personastateflags")]
        public int Personastateflags { get { return personastateflags; } set { personastateflags = value; } }

        string loccountrycode;
        [JsonPropertyName("loccountrycode")]
        public string Loccountrycode { get { return loccountrycode; } set { loccountrycode = value; } }
        
        [JsonPropertyName("realname")]
        public string Realname { get; set; }

        [JsonPropertyName("gameextrainfo")]
        public string Gameextrainfo { get; set; }

        [JsonPropertyName("gameid")]
        public string Gameid { get; set; }

        [JsonPropertyName("locstatecode")]
        public string Locstatecode { get; set; }

        [JsonPropertyName("loccityid")]
        public int Loccityid { get; set; }
        
    }
}
