using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenViolationViolationeventBatchqueryResponse.
    /// </summary>
    public class AlipayOpenViolationViolationeventBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 违规记录列表
        /// </summary>
        [XmlElement("violation_record_infos")]
        public ViolationEvent ViolationRecordInfos { get; set; }
    }
}
