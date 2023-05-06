using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayIserviceCognitiveKgopenQueryResponse.
    /// </summary>
    public class AlipayIserviceCognitiveKgopenQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回数据
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
