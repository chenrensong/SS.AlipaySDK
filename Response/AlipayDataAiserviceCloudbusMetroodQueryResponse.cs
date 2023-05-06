using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusMetroodQueryResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusMetroodQueryResponse : AopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public MetroOdDetailResult Result { get; set; }
    }
}
