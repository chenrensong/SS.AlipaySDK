using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayPayAppCarSignResponse.
    /// </summary>
    public class AlipayPayAppCarSignResponse : AopResponse
    {
        /// <summary>
        /// 上下文token
        /// </summary>
        [XmlElement("context_token")]
        public string ContextToken { get; set; }
    }
}
