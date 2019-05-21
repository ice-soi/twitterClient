using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiyoDotter.Data
{

    // Type created for JSON at <<root>>
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class JsonTweetSearchData
    {

        [System.Runtime.Serialization.DataMemberAttribute()]
        public Statuses[] statuses;
    }

    // Type created for JSON at <<root>> --> statuses
    [System.Runtime.Serialization.DataContractAttribute(Name = "statuses")]
    public partial class Statuses
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
        public object in_reply_to_user_id;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public User1 user;
    }

    // Type created for JSON at <<root>> --> retweeted_status --> user
    [System.Runtime.Serialization.DataContractAttribute(Name = "user")]
    public partial class User1
    {

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string id_str;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string screen_name;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string created_at;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string profile_image_url;
    }

}
