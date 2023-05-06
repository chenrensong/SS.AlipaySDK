using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayIserviceCognitiveOcrImageclassifyQueryResponse.
    /// </summary>
    public class AlipayIserviceCognitiveOcrImageclassifyQueryResponse : AopResponse
    {
        /// <summary>
        /// 图像分类类型
        /// </summary>
        [XmlElement("image_type")]
        public string ImageType { get; set; }
    }
}
