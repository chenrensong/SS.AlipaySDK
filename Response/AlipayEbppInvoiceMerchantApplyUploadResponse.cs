using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayEbppInvoiceMerchantApplyUploadResponse.
    /// </summary>
    public class AlipayEbppInvoiceMerchantApplyUploadResponse : AopResponse
    {
        /// <summary>
        /// 发票号码
        /// </summary>
        [XmlElement("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [XmlElement("invoice_no")]
        public string InvoiceNo { get; set; }
    }
}
