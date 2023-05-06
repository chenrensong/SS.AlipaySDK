using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMarketingActivityVoucherPublishResponse.
    /// </summary>
    public class AlipayMarketingActivityVoucherPublishResponse : AopResponse
    {
        /// <summary>
        /// 预充值链接
        /// </summary>
        [XmlElement("recharge_url")]
        public string RechargeUrl { get; set; }
    }
}
