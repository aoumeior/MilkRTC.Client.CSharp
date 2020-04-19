using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PeerConnectionClientCore.Utilities.ServiceDepend
{
    [DataContract]
    public class RoomJoin
    {
        [DataMember(Name = "currentRoomName")]
        public string currentRoomName = "defaultname";
    }

    [DataContract]
    public class MsgData
    {
        [DataMember(Name = "apiVersion")]
        public string apiVersion = "1.1.1-beta";
        // [DataMember(Name = "roomJoin")]
        // public RoomJoin roomJoin = new RoomJoin();
    }

    [DataContract]
    public class setUserCfg
    {
        [DataMember(Name = "userSettings")]
        public userSettings UserSettings = new userSettings();
    }

    [DataContract]
    public class userSettings
    {
        [DataMember]
        public Boolean sharingAudio = true;
        [DataMember]
        public Boolean sharingVideo = true;
        [DataMember]
        public Boolean sharingData = false;
        [DataMember]
        public int nativeVideoWidth = 640;
        [DataMember]
        public int nativeVideoHeight = 480;
        [DataMember]
        public int windowWidth = 1200;
        [DataMember]
        public int windowHeight = 663;
        [DataMember]
        public int screenWidth = 1200;
        [DataMember]
        public int screenHeight = 800;
        [DataMember]
        public Boolean cookieEnabled = true;
        [DataMember]
        public string language = "zh-CN";
    }
    [DataContract]
    public class msgT
    {
        [DataMember(Name = "apiVersion")]
        public string apiVersion = "1.1.1-beta";
        [DataMember(Name = "applicationName")]
        public string applicationName = "easyrtc.audioVideoSimple";

        [DataMember(Name = "msgType")]
        public string msgType;
        [DataMember(Name = "msgData")]
        public MsgData msgData = new MsgData();

        [DataMember(Name = "setUserCfg")]
        public setUserCfg SetUserCfg = new setUserCfg();
    }
}
