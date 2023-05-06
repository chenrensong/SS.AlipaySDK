using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceAlideviceinfoOfflinecodeCreateResponse.
    /// </summary>
    public class AlipayCommerceAlideviceinfoOfflinecodeCreateResponse : AopResponse
    {
        /// <summary>
        /// 机具统一ID
        /// </summary>
        [XmlElement("biz_tid")]
        public string BizTid { get; set; }

        /// <summary>
        /// 离线支付token
        /// </summary>
        [XmlElement("token")]
        public string Token { get; set; }
    }
}
