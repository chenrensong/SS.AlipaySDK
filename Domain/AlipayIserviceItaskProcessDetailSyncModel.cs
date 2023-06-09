using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayIserviceItaskProcessDetailSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceItaskProcessDetailSyncModel : AopObject
    {
        /// <summary>
        /// 需要同步的蚂蚁域内的具体工单平台
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 接口客户端名称
        /// </summary>
        [XmlElement("exapp_name")]
        public string ExappName { get; set; }

        /// <summary>
        /// 外部系统工单处理同学id
        /// </summary>
        [XmlElement("exsystem_operator_id")]
        public string ExsystemOperatorId { get; set; }

        /// <summary>
        /// 外部系统对工单进行处理的人员名称
        /// </summary>
        [XmlElement("exsystem_operator_name")]
        public string ExsystemOperatorName { get; set; }

        /// <summary>
        /// 外部系统的工单id
        /// </summary>
        [XmlElement("exsystem_ticket_id")]
        public string ExsystemTicketId { get; set; }

        /// <summary>
        /// 外部系统的工单状态，枚举值，目前只有一个值: COMPLETED。  如果传空，默认为 COMPLETED 。
        /// </summary>
        [XmlElement("exsystem_ticket_state")]
        public string ExsystemTicketState { get; set; }

        /// <summary>
        /// 外部工单业务扩展字段列表，业务属性信息都放置在此字段。
        /// </summary>
        [XmlArray("extend_field_infos")]
        [XmlArrayItem("extend_field_info")]
        public List<ExtendFieldInfo> ExtendFieldInfos { get; set; }
    }
}
