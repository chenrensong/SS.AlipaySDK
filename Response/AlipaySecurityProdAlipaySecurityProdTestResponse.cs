using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipaySecurityProdAlipaySecurityProdTestResponse.
    /// </summary>
    public class AlipaySecurityProdAlipaySecurityProdTestResponse : AopResponse
    {
        /// <summary>
        /// ddd
        /// </summary>
        [XmlElement("admin")]
        public string Admin { get; set; }
    }
}
