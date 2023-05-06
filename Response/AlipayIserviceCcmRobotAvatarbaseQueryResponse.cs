using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayIserviceCcmRobotAvatarbaseQueryResponse.
    /// </summary>
    public class AlipayIserviceCcmRobotAvatarbaseQueryResponse : AopResponse
    {
        /// <summary>
        /// result:方法调用返回值响应 k-v map
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
