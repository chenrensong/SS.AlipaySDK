using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenMiniTemplateMarketingCreateResponse.
    /// </summary>
    public class AlipayOpenMiniTemplateMarketingCreateResponse : AopResponse
    {
        /// <summary>
        /// 投放详情主键id
        /// </summary>
        [XmlElement("detail_id")]
        public string DetailId { get; set; }
    }
}
