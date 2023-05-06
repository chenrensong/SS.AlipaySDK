using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipaySecurityBayuQueryResponse.
    /// </summary>
    public class AlipaySecurityBayuQueryResponse : AopResponse
    {
        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }
    }
}
