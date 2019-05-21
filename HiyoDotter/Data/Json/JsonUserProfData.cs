using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiyoDotter.Data.Json
{ 
    // Type created for JSON at <<root>>
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class JsonUserProfData
    {
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string id_str;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string description;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string location;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string profile_image_url;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string screen_name;
    }
    
}
