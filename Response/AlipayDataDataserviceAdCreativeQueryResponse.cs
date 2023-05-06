using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdCreativeQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdCreativeQueryResponse : AopResponse
    {
        /// <summary>
        /// 创意详情
        /// </summary>
        [XmlElement("creative_detail")]
        public CreativeDetail CreativeDetail { get; set; }
    }
}
