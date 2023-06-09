using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayIserviceCognitiveBillInferenceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCognitiveBillInferenceQueryModel : AopObject
    {
        /// <summary>
        /// 图片大小
        /// </summary>
        [XmlElement("image_content")]
        public string ImageContent { get; set; }
    }
}
