using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieSitesQueryResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieSitesQueryResponse : AopResponse
    {
        /// <summary>
        /// 站点查询返回值
        /// </summary>
        [XmlElement("data")]
        public FengdieSitesQueryRespModel Data { get; set; }
    }
}
