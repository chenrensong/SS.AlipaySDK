using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayFundTransInvoiceFromisvnotifyModifyResponse.
    /// </summary>
    public class AlipayFundTransInvoiceFromisvnotifyModifyResponse : AopResponse
    {
        /// <summary>
        /// 票据详情页url
        /// </summary>
        [XmlElement("invoice_url")]
        public string InvoiceUrl { get; set; }
    }
}
