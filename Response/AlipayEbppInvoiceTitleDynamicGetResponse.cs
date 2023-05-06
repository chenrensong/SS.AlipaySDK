using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayEbppInvoiceTitleDynamicGetResponse.
    /// </summary>
    public class AlipayEbppInvoiceTitleDynamicGetResponse : AopResponse
    {
        /// <summary>
        /// 发票抬头
        /// </summary>
        [XmlElement("title")]
        public InvoiceTitleModel Title { get; set; }
    }
}
