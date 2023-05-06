using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayFincoreComplianceRcservcenterRcsmartQueryResponse.
    /// </summary>
    public class AlipayFincoreComplianceRcservcenterRcsmartQueryResponse : AopResponse
    {
        /// <summary>
        /// 内容审核结果
        /// </summary>
        [XmlElement("rc_smart_audit_response")]
        public RcSmartAuditResponse RcSmartAuditResponse { get; set; }
    }
}
