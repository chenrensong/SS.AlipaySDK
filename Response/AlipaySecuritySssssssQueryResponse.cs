using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipaySecuritySssssssQueryResponse.
    /// </summary>
    public class AlipaySecuritySssssssQueryResponse : AopResponse
    {
        /// <summary>
        /// af
        /// </summary>
        [XmlElement("adfad")]
        public string Adfad { get; set; }
    }
}
