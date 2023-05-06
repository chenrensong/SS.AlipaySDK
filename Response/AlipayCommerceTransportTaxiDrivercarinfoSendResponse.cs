using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceTransportTaxiDrivercarinfoSendResponse.
    /// </summary>
    public class AlipayCommerceTransportTaxiDrivercarinfoSendResponse : AopResponse
    {
        /// <summary>
        /// 状态码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 响应描述信息
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }
    }
}
