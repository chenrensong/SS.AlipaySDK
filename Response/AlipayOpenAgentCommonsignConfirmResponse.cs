using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenAgentCommonsignConfirmResponse.
    /// </summary>
    public class AlipayOpenAgentCommonsignConfirmResponse : AopResponse
    {
        /// <summary>
        /// 签约单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
