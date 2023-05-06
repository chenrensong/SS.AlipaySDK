using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayInsSceneEcommercePreorderquoteConsultResponse.
    /// </summary>
    public class AlipayInsSceneEcommercePreorderquoteConsultResponse : AopResponse
    {
        /// <summary>
        /// 预下单数据及最新报价
        /// </summary>
        [XmlElement("pre_order")]
        public InsPreOrderDTO PreOrder { get; set; }
    }
}
