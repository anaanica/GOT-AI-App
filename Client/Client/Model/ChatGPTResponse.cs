using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model
{
    [DataContract]
    internal class ChatGPTResponse
    {
        [DataMember(Order = 0)]
        public string Result { get; set; }

        [DataMember(Order = 1)]
        public bool Status { get; set; }

        [DataMember(Name = "server_code", Order = 2)]
        public int ServerCode { get; set; }

        public ChatGPTResponse(string result, bool status, int serverCode)
        {
            Result = result;
            Status = status;
            ServerCode = serverCode;
        }

        public ChatGPTResponse()
        {
        }

        public override string ToString()
        {
            return Result;
        }
    }
}
