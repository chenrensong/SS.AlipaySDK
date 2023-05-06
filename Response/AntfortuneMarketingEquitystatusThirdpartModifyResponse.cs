using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AntfortuneMarketingEquitystatusThirdpartModifyResponse.
    /// </summary>
    public class AntfortuneMarketingEquitystatusThirdpartModifyResponse : AopResponse
    {
        /// <summary>
        /// 返回值：true或者false
        /// </summary>
        [XmlElement("should_retry")]
        public string ShouldRetry { get; set; }
    }
}
