using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayEbppInvoiceTopregisterCompanyQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceTopregisterCompanyQueryResponse : AopResponse
    {
        /// <summary>
        /// 企业税务信息查询输出
        /// </summary>
        [XmlElement("result")]
        public InvoiceCompanyQueryResult Result { get; set; }
    }
}
