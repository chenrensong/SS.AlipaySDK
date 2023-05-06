using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusTotalodQueryResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusTotalodQueryResponse : AopResponse
    {
        /// <summary>
        /// 客流总量结果
        /// </summary>
        [XmlElement("result")]
        public CloudbusTotalOdItem Result { get; set; }
    }
}
