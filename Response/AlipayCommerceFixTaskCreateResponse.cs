using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceFixTaskCreateResponse.
    /// </summary>
    public class AlipayCommerceFixTaskCreateResponse : AopResponse
    {
        /// <summary>
        /// 创建成功工单的唯一标识id。
        /// </summary>
        [XmlElement("task_id")]
        public long TaskId { get; set; }
    }
}
