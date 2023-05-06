using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataAiserviceHellobikeSiteQueryResponse.
    /// </summary>
    public class AlipayDataAiserviceHellobikeSiteQueryResponse : AopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public SiteResult Result { get; set; }
    }
}
