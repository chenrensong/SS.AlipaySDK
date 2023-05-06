using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// CustomVoiceVO Data Structure.
    /// </summary>
    [Serializable]
    public class CustomVoiceVO : AopObject
    {
        /// <summary>
        /// 语音文件id
        /// </summary>
        [XmlElement("audio_id")]
        public string AudioId { get; set; }
    }
}
