using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayEbppInvoiceIssueruleModifyResponse.
    /// </summary>
    public class AlipayEbppInvoiceIssueruleModifyResponse : AopResponse
    {
        /// <summary>
        /// 修改结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
