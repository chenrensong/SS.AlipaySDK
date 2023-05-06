using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipaySecurityProdUmidQueryResponse.
    /// </summary>
    public class AlipaySecurityProdUmidQueryResponse : AopResponse
    {
        /// <summary>
        /// umid:客户端对应的UMID值，从UMID系统获取。
        /// </summary>
        [XmlElement("umid")]
        public string Umid { get; set; }
    }
}
