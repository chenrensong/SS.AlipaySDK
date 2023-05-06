using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AftAifinFireeyeOcrImageQueryResponse.
    /// </summary>
    public class AftAifinFireeyeOcrImageQueryResponse : AopResponse
    {
        /// <summary>
        /// 识别结果字段，这个是一个JSON字符串
        /// </summary>
        [XmlElement("content")]
        public OcrIdentifyResult Content { get; set; }
    }
}
