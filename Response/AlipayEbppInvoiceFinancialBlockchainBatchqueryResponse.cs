using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayEbppInvoiceFinancialBlockchainBatchqueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceFinancialBlockchainBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 发票列表
        /// </summary>
        [XmlArray("invoice_element_list")]
        [XmlArrayItem("invoice_element_model")]
        public List<InvoiceElementModel> InvoiceElementList { get; set; }
    }
}
