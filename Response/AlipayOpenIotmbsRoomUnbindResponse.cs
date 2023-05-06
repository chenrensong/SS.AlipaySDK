using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenIotmbsRoomUnbindResponse.
    /// </summary>
    public class AlipayOpenIotmbsRoomUnbindResponse : AopResponse
    {
        /// <summary>
        /// 成功true失败false
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
