using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenOpenbizmockAppidDetectResponse.
    /// </summary>
    public class AlipayOpenOpenbizmockAppidDetectResponse : AopResponse
    {
        /// <summary>
        /// 检测结果
        /// </summary>
        [XmlElement("detect_response")]
        public string DetectResponse { get; set; }
    }
}
