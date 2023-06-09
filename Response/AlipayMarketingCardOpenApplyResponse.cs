using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMarketingCardOpenApplyResponse.
    /// </summary>
    public class AlipayMarketingCardOpenApplyResponse : AopResponse
    {
        /// <summary>
        /// 商户卡信息（包括支付宝分配的业务卡号）
        /// </summary>
        [XmlElement("card_info")]
        public MerchantCard CardInfo { get; set; }
    }
}
