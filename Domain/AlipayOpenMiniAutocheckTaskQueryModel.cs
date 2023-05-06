using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayOpenMiniAutocheckTaskQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniAutocheckTaskQueryModel : AopObject
    {
        /// <summary>
        /// 任务ID
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
