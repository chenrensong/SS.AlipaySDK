using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipaySecurityProdHahaTestdddQueryResponse.
    /// </summary>
    public class AlipaySecurityProdHahaTestdddQueryResponse : AopResponse
    {
        /// <summary>
        /// 测试
        /// </summary>
        [XmlElement("haha")]
        public string Haha { get; set; }
    }
}
