using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AnttechOceanbaseTestplatformTaskSyncResponse.
    /// </summary>
    public class AnttechOceanbaseTestplatformTaskSyncResponse : AopResponse
    {
        /// <summary>
        /// 任务id
        /// </summary>
        [XmlElement("task_id")]
        public long TaskId { get; set; }

        /// <summary>
        /// 测试结果反馈
        /// </summary>
        [XmlElement("task_info")]
        public string TaskInfo { get; set; }
    }
}
