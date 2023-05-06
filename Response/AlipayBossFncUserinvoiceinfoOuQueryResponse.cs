using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayBossFncUserinvoiceinfoOuQueryResponse.
    /// </summary>
    public class AlipayBossFncUserinvoiceinfoOuQueryResponse : AopResponse
    {
        /// <summary>
        /// 开票资料
        /// </summary>
        [XmlElement("result_set")]
        public ApUserInvoiceInfoOpenApiResponse ResultSet { get; set; }
    }
}
