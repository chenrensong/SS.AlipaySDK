using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceOperationTimescardItemQueryResponse.
    /// </summary>
    public class AlipayCommerceOperationTimescardItemQueryResponse : AopResponse
    {
        /// <summary>
        /// 次卡商品信息
        /// </summary>
        [XmlElement("data")]
        public TimeCardItemInfo Data { get; set; }
    }
}
