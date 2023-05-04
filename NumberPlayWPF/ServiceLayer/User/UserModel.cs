using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NumberPlayWPF.ServiceLayer.User
{
   public class UserModel
    {
        [JsonProperty("ID")]
        public int ID { get; set; }
        [JsonProperty("FirstName")]
        public string FirstName { get; set; }
        [JsonProperty("LastName")]
        public string LastName { get; set; }
        [JsonProperty("Username")]
        public string Username { get; set; }
        [JsonProperty("Answer")]
        public string Answer { get; set; }
        [JsonProperty("AllAnswer")]
        public string AllAnswer { get; set; }
        [JsonProperty("Time")]
        public string Time { get; set; }
    }
}
