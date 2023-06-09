using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayEbppCommonNotifySendResponse.
    /// </summary>
    public class AlipayEbppCommonNotifySendResponse : AopResponse
    {
        /// <summary>
        /// 通知的执行结果
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
