using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipaySecurityProdAfsrcWhitehatinfoQueryResponse.
    /// </summary>
    public class AlipaySecurityProdAfsrcWhitehatinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 白帽子信息
        /// </summary>
        [XmlElement("data")]
        public WhitehatInfo Data { get; set; }
    }
}
