using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayFincoreComplianceRcservcenterRcdisposalQueryResponse.
    /// </summary>
    public class AlipayFincoreComplianceRcservcenterRcdisposalQueryResponse : AopResponse
    {
        /// <summary>
        /// 处罚结果
        /// </summary>
        [XmlElement("punish_status_result")]
        public PunishStatusResult PunishStatusResult { get; set; }
    }
}
