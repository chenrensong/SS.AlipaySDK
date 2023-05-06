using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceIotPrintmodelPrintSendResponse.
    /// </summary>
    public class AlipayCommerceIotPrintmodelPrintSendResponse : AopResponse
    {
        /// <summary>
        /// 调用任务id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
