using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HiyoDotter.Data
{ 
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class JsonData
    {
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string created_at;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string id_str;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string text;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string source;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public object in_reply_to_status_id;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public Boolean retweeted;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public User user;
    }

    [System.Runtime.Serialization.DataContractAttribute(Name = "user")]
    public partial class User
    {
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string id_str;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string screen_name;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string profile_image_url;
    }
}
