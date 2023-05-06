using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiMarketingAdvertisingCreateResponse.
    /// </summary>
    public class KoubeiMarketingAdvertisingCreateResponse : AopResponse
    {
        /// <summary>
        /// 创建广告唯一标识
        /// </summary>
        [XmlElement("ad_id")]
        public string AdId { get; set; }
    }
}
