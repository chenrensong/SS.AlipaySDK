using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateResponse.
    /// </summary>
    public class AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateResponse : AopResponse
    {
        /// <summary>
        /// 开票规则ID
        /// </summary>
        [XmlElement("invoice_rule_id")]
        public string InvoiceRuleId { get; set; }
    }
}
