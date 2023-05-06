using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayInsSceneEcommercePreorderquoteRefreshResponse.
    /// </summary>
    public class AlipayInsSceneEcommercePreorderquoteRefreshResponse : AopResponse
    {
        /// <summary>
        /// 更新后的预下单数据
        /// </summary>
        [XmlElement("pre_order")]
        public InsPreOrderDTO PreOrder { get; set; }
    }
}
