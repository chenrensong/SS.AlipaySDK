using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayDataAiserviceHellobikeSiteQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataAiserviceHellobikeSiteQueryModel : AopObject
    {
        /// <summary>
        /// 任务id.  （当空时，返回最近3个月的所有任务及状态）
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }
    }
}
