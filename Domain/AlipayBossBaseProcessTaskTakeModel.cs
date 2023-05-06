using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayBossBaseProcessTaskTakeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossBaseProcessTaskTakeModel : AopObject
    {
        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 当前流程实例节点名,如果未填,则自动获取当前状态,若当前仅有一个节点,则按此处理,否则报错
        /// </summary>
        [XmlElement("node")]
        public string Node { get; set; }

        /// <summary>
        /// 处理人域账号
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 操作人工号
        /// </summary>
        [XmlElement("operator_work_no")]
        public string OperatorWorkNo { get; set; }

        /// <summary>
        /// 流程全局唯一ID
        /// </summary>
        [XmlElement("puid")]
        public string Puid { get; set; }
    }
}
