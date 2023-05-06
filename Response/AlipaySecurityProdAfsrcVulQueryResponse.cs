using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipaySecurityProdAfsrcVulQueryResponse.
    /// </summary>
    public class AlipaySecurityProdAfsrcVulQueryResponse : AopResponse
    {
        /// <summary>
        /// 漏洞信息
        /// </summary>
        [XmlElement("data")]
        public VulInfo Data { get; set; }
    }
}
