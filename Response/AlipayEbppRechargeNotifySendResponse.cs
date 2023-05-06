using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayEbppRechargeNotifySendResponse.
    /// </summary>
    public class AlipayEbppRechargeNotifySendResponse : AopResponse
    {
        /// <summary>
        /// 操作状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
