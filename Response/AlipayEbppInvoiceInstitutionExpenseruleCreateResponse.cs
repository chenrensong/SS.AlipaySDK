using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayEbppInvoiceInstitutionExpenseruleCreateResponse.
    /// </summary>
    public class AlipayEbppInvoiceInstitutionExpenseruleCreateResponse : AopResponse
    {
        /// <summary>
        /// 使用规则id
        /// </summary>
        [XmlElement("standard_id")]
        public string StandardId { get; set; }
    }
}
