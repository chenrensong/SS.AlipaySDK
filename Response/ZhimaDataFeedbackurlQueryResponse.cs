using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// ZhimaDataFeedbackurlQueryResponse.
    /// </summary>
    public class ZhimaDataFeedbackurlQueryResponse : AopResponse
    {
        /// <summary>
        /// 反馈模板地址
        /// </summary>
        [XmlElement("feedback_url")]
        public string FeedbackUrl { get; set; }
    }
}
