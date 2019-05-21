using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiyoDotter.Data
{
   
        [System.Runtime.Serialization.DataContractAttribute()]
        public  partial class JsonUserSearchData
        {
            [System.Runtime.Serialization.DataMemberAttribute()]
            public string id_str { get; set; }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string name { get; set; }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string screen_name { get; set; }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string profile_image_url { get; set; }
        }   
}
