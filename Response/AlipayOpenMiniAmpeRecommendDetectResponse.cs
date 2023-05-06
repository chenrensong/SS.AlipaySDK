using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenMiniAmpeRecommendDetectResponse.
    /// </summary>
    public class AlipayOpenMiniAmpeRecommendDetectResponse : AopResponse
    {
        /// <summary>
        /// true:有效 false: 无效
        /// </summary>
        [XmlElement("valid")]
        public bool Valid { get; set; }
    }
}
