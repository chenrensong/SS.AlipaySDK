using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenPublicXwbtestabcdBatchqueryResponse.
    /// </summary>
    public class AlipayOpenPublicXwbtestabcdBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 1111
        /// </summary>
        [XmlElement("b")]
        public string B { get; set; }
    }
}
