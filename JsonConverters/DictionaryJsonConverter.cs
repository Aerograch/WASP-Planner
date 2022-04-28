using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace WASP_Planner.JsonConverter
{
    class DictionaryJsonConverter : JsonConverter<Dictionary<DateTime, string>>
    {
        public override Dictionary<DateTime, string> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string jsonReturn = reader.GetString();
            List<string> keyValuePairs = jsonReturn.Replace("\n", "").Replace(" ", "").Split(',').ToList();
            Dictionary<DateTime, string> output = new Dictionary<DateTime, string>();
            foreach(string s in keyValuePairs)
            {
                string[] buffer = s.Split(':');
                output[DateTime.Parse(buffer[0])] = buffer[1];
            }
            return output;
        }

        public override void Write(Utf8JsonWriter writer, Dictionary<DateTime, string> value, JsonSerializerOptions options)
        {
            string output = string.Empty;
            for(int i = 0; i < value.Count; i++)
            {
                output += $"{value.Keys.ToArray()[i]}: {value.Values.ToArray()[i]}";
                if (i != value.Count - 1)
                {
                    output += ",";
                }
            }
            writer.WriteStringValue(output);
        }
    }
}
