using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenPublicGroupCrowdQueryResponse.
    /// </summary>
    public class AlipayOpenPublicGroupCrowdQueryResponse : AopResponse
    {
        /// <summary>
        /// 分组圈出的人群数量
        /// </summary>
        [XmlElement("count")]
        public string Count { get; set; }
    }
}
