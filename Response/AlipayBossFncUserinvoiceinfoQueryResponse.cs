using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayBossFncUserinvoiceinfoQueryResponse.
    /// </summary>
    public class AlipayBossFncUserinvoiceinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询返回结果：开票资料
        /// </summary>
        [XmlElement("result_set")]
        public UserInvoiceInfoOpenApiResponse ResultSet { get; set; }
    }
}
