using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AnttechAiCvTfjsModelversionQueryResponse.
    /// </summary>
    public class AnttechAiCvTfjsModelversionQueryResponse : AopResponse
    {
        /// <summary>
        /// 对应模型最新版本号
        /// </summary>
        [XmlElement("model_version")]
        public string ModelVersion { get; set; }
    }
}
