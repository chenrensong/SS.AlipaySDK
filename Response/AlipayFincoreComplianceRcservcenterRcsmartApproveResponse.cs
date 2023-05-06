using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayFincoreComplianceRcservcenterRcsmartApproveResponse.
    /// </summary>
    public class AlipayFincoreComplianceRcservcenterRcsmartApproveResponse : AopResponse
    {
        /// <summary>
        /// 解语花统一返回对象
        /// </summary>
        [XmlElement("rc_smart_response")]
        public RcSmartResponse RcSmartResponse { get; set; }
    }
}
