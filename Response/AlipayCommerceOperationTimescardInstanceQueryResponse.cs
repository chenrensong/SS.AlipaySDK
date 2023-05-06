using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceOperationTimescardInstanceQueryResponse.
    /// </summary>
    public class AlipayCommerceOperationTimescardInstanceQueryResponse : AopResponse
    {
        /// <summary>
        /// 次卡信息
        /// </summary>
        [XmlElement("data")]
        public TimeCardInfo Data { get; set; }
    }
}
