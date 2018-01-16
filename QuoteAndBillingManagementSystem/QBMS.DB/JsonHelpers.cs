using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QBMS.DB
{
    public class JsonHelpers
    {
        public static string ConvertToJson(object obj)
        {
            var jsonSerializerSettings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };
            return JsonConvert.SerializeObject(obj, jsonSerializerSettings);
        }

        public static T ConvertFromJson<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}