using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayInsSceneClaimNewreportCreateResponse.
    /// </summary>
    public class AlipayInsSceneClaimNewreportCreateResponse : AopResponse
    {
        /// <summary>
        /// 保单单据号
        /// </summary>
        [XmlElement("claim_report_no")]
        public string ClaimReportNo { get; set; }
    }
}
