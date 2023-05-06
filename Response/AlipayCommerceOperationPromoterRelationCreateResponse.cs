using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceOperationPromoterRelationCreateResponse.
    /// </summary>
    public class AlipayCommerceOperationPromoterRelationCreateResponse : AopResponse
    {
        /// <summary>
        /// 门店推广员创建处理结果
        /// </summary>
        [XmlElement("promoter_create_result")]
        public PromoterCreateInfo PromoterCreateResult { get; set; }
    }
}
