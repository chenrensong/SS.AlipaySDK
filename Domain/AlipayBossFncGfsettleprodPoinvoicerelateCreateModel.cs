using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayBossFncGfsettleprodPoinvoicerelateCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncGfsettleprodPoinvoicerelateCreateModel : AopObject
    {
        /// <summary>
        /// 发票创建关联请求
        /// </summary>
        [XmlElement("input_invoice_order_request")]
        public InputInvoiceOrderRequest InputInvoiceOrderRequest { get; set; }
    }
}
