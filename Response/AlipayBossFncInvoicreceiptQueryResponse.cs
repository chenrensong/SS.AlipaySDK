using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayBossFncInvoicreceiptQueryResponse.
    /// </summary>
    public class AlipayBossFncInvoicreceiptQueryResponse : AopResponse
    {
        /// <summary>
        /// 开票单据返回对象
        /// </summary>
        [XmlElement("result_set")]
        public ArInvoiceReceiptQueryOpenApiDTO ResultSet { get; set; }
    }
}
