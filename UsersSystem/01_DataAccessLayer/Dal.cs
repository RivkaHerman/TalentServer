using System.Collections.Generic;
using System.Configuration;
using System.IO;
using Newtonsoft.Json;


namespace JB
{
    public class Dal
    {
        public List<User> users { get; set; }

        public Dal()
        {
            users = JsonConvert.DeserializeObject<List<User>>(File.ReadAllText(ConfigurationManager.AppSettings["FILE_PATH"].ToString()));//@"c:\users.json"
        }

    }
}
