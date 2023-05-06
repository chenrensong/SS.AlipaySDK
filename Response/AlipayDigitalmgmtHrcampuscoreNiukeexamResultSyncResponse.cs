using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDigitalmgmtHrcampuscoreNiukeexamResultSyncResponse.
    /// </summary>
    public class AlipayDigitalmgmtHrcampuscoreNiukeexamResultSyncResponse : AopResponse
    {
        /// <summary>
        /// 牛客考试结果回调结果
        /// </summary>
        [XmlElement("niuke_exam_callback_result")]
        public NiukeExamCallbackResult NiukeExamCallbackResult { get; set; }

        /// <summary>
        /// 服务调用是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
