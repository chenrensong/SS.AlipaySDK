using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayBossFncGfsettleprodInvoiceQueryResponse.
    /// </summary>
    public class AlipayBossFncGfsettleprodInvoiceQueryResponse : AopResponse
    {
        /// <summary>
        /// 发票结果
        /// </summary>
        [XmlArray("result_set")]
        [XmlArrayItem("invoice_response_d_t_o")]
        public List<InvoiceResponseDTO> ResultSet { get; set; }
    }
}
