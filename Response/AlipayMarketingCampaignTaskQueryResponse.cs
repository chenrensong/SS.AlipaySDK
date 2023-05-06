using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMarketingCampaignTaskQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignTaskQueryResponse : AopResponse
    {
        /// <summary>
        /// 任务中心（方案）基本信息
        /// </summary>
        [XmlElement("task_base_info")]
        public TaskBaseInfo TaskBaseInfo { get; set; }

        /// <summary>
        /// 任务中心唯一id
        /// </summary>
        [XmlElement("task_cen_id")]
        public string TaskCenId { get; set; }

        /// <summary>
        /// 任务中心下每个任务详情
        /// </summary>
        [XmlArray("task_full_list")]
        [XmlArrayItem("task_full_info")]
        public List<TaskFullInfo> TaskFullList { get; set; }
    }
}
