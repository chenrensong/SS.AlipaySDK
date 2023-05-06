using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataDataserviceConsumRatioQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceConsumRatioQueryResponse : AopResponse
    {
        /// <summary>
        /// 占比数据接口返回数据结构
        /// </summary>
        [XmlElement("ratio_detail")]
        public RatioDetail RatioDetail { get; set; }
    }
}
