using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOverseasTransferPaymentCancelResponse.
    /// </summary>
    public class AlipayOverseasTransferPaymentCancelResponse : AopResponse
    {
        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("pass_through_info")]
        public string PassThroughInfo { get; set; }
    }
}
