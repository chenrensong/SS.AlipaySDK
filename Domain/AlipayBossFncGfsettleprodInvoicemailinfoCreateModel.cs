using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayBossFncGfsettleprodInvoicemailinfoCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncGfsettleprodInvoicemailinfoCreateModel : AopObject
    {
        /// <summary>
        /// 邮寄信息
        /// </summary>
        [XmlElement("invoice_mail_info_orde_dto")]
        public InvoiceMailInfoOrderDTO InvoiceMailInfoOrdeDto { get; set; }
    }
}
