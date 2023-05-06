using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayEbppInvoiceExpenserulesSceneruleCreateResponse.
    /// </summary>
    public class AlipayEbppInvoiceExpenserulesSceneruleCreateResponse : AopResponse
    {
        /// <summary>
        /// 费控规则ID
        /// </summary>
        [XmlElement("standard_id")]
        public string StandardId { get; set; }
    }
}
