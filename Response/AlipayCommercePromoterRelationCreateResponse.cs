using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommercePromoterRelationCreateResponse.
    /// </summary>
    public class AlipayCommercePromoterRelationCreateResponse : AopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
