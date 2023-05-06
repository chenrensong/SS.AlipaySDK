using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDiscoveryTaxiOrderConfirmResponse.
    /// </summary>
    public class AlipayDiscoveryTaxiOrderConfirmResponse : AopResponse
    {
        /// <summary>
        /// 返回结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }
    }
}
