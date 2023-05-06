using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayEbppInvoiceInfoGetResponse.
    /// </summary>
    public class AlipayEbppInvoiceInfoGetResponse : AopResponse
    {
        /// <summary>
        /// 电子发票详情模型
        /// </summary>
        [XmlElement("invoice_model")]
        public InvoiceModelContent InvoiceModel { get; set; }
    }
}
