using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceEcApprovalModifyResponse.
    /// </summary>
    public class AlipayCommerceEcApprovalModifyResponse : AopResponse
    {
        /// <summary>
        /// 外部平台审批单id
        /// </summary>
        [XmlElement("platform_approval_id")]
        public string PlatformApprovalId { get; set; }
    }
}
