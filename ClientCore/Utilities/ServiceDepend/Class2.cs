using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PeerConnectionClientCore.Utilities.ServiceDepend
{
    [DataContract]
    class fieldValue
    {
        [DataMember(Name = "default")]
        public string Default = "nY4IIl6HkJ91v2MmE80TE37Kpe8NfqgUn1rM";
    }

    [DataContract]
    class mediaIds
    {
        [DataMember(Name = "fieldName")]
        public string fieldName = "mediaIds";
        [DataMember(Name = "fieldValue")]
        public fieldValue FieldValue = new fieldValue();
    }

    [DataContract]
    class field
    {
        [DataMember(Name = "mediaIds")]
        public mediaIds MediaIds = new mediaIds();
    }

    [DataContract]
    public class setRoomApiField
    {
        [DataMember(Name = "roomName")]
        public string roomName = "default";

        [DataMember(Name = "field")]
        field Field = new field();
    }
    [DataContract]
    public class msgData1
    {
        [DataMember(Name = "setRoomApiField")]
        setRoomApiField SetRoomApiField = new setRoomApiField();
    }
    [DataContract]
    public class TestTT
    {
        [DataMember(Name = "msgType")]
        public string msgType = "setRoomApiField";

        [DataMember(Name = "msgData")]
        msgData1 MsgData = new msgData1();
    }
}
