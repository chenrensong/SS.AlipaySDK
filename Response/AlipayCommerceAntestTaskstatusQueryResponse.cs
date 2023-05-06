using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceAntestTaskstatusQueryResponse.
    /// </summary>
    public class AlipayCommerceAntestTaskstatusQueryResponse : AopResponse
    {
        /// <summary>
        /// 任务状态： INIT 已创建，EXECUTING 执行中，FINISH 已完成，CANCEL 已取消
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
