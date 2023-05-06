using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMerchantQipanCrowdCreateResponse.
    /// </summary>
    public class AlipayMerchantQipanCrowdCreateResponse : AopResponse
    {
        /// <summary>
        /// 支付宝人群code
        /// </summary>
        [XmlElement("crowd_code")]
        public string CrowdCode { get; set; }
    }
}
