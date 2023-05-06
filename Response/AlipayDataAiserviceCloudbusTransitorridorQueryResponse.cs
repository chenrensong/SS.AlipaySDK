using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusTransitorridorQueryResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusTransitorridorQueryResponse : AopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public CloudbusTransitResultItem Result { get; set; }
    }
}
