using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipaySecurityProdVoiceQuestionQueryResponse.
    /// </summary>
    public class AlipaySecurityProdVoiceQuestionQueryResponse : AopResponse
    {
        /// <summary>
        /// 问题推荐结果
        /// </summary>
        [XmlElement("question_result")]
        public string QuestionResult { get; set; }
    }
}
