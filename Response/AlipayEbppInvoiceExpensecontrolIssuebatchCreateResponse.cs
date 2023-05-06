using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayEbppInvoiceExpensecontrolIssuebatchCreateResponse.
    /// </summary>
    public class AlipayEbppInvoiceExpensecontrolIssuebatchCreateResponse : AopResponse
    {
        /// <summary>
        /// 发放批次id
        /// </summary>
        [XmlElement("issue_batch_id")]
        public string IssueBatchId { get; set; }

        /// <summary>
        /// 校验失败的数据
        /// </summary>
        [XmlArray("issue_quota_check_failed_list")]
        [XmlArrayItem("issue_quota_check_info")]
        public List<IssueQuotaCheckInfo> IssueQuotaCheckFailedList { get; set; }
    }
}
