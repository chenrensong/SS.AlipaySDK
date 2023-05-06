using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMarketingIotMerchantplanCreateormodifyResponse.
    /// </summary>
    public class AlipayMarketingIotMerchantplanCreateormodifyResponse : AopResponse
    {
        /// <summary>
        /// 商家活动ID
        /// </summary>
        [XmlElement("merchant_plan_id")]
        public string MerchantPlanId { get; set; }
    }
}
