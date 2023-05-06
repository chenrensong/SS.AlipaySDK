using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipaySecurityProdFacePayCreateResponse.
    /// </summary>
    public class AlipaySecurityProdFacePayCreateResponse : AopResponse
    {
        /// <summary>
        /// 2
        /// </summary>
        [XmlElement("bbb")]
        public string Bbb { get; set; }
    }
}
