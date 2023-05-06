using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayBossFncInvoiceQueryResponse.
    /// </summary>
    public class AlipayBossFncInvoiceQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询返回结果：发票信息
        /// </summary>
        [XmlElement("result_set")]
        public ArInvoiceOpenApiResponse ResultSet { get; set; }
    }
}
