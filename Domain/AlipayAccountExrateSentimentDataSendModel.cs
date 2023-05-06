using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayAccountExrateSentimentDataSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAccountExrateSentimentDataSendModel : AopObject
    {
        /// <summary>
        /// 国家制裁提交数据内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }
    }
}
