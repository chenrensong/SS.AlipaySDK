using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdGroupQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdGroupQueryResponse : AopResponse
    {
        /// <summary>
        /// 单元详情
        /// </summary>
        [XmlElement("group_detail")]
        public OuterGroup GroupDetail { get; set; }
    }
}
