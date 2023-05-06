using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayEcoTextDetectResponse.
    /// </summary>
    public class AlipayEcoTextDetectResponse : AopResponse
    {
        /// <summary>
        /// 检测结果
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("spi_detection_detail")]
        public List<SpiDetectionDetail> Data { get; set; }
    }
}
