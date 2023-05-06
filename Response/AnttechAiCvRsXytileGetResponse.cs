using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AnttechAiCvRsXytileGetResponse.
    /// </summary>
    public class AnttechAiCvRsXytileGetResponse : AopResponse
    {
        /// <summary>
        /// 图片原始内容
        /// </summary>
        [XmlElement("image")]
        public string Image { get; set; }
    }
}
