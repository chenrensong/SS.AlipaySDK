using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayMarketingDataDashboardCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingDataDashboardCancelModel : AopObject
    {
        /// <summary>
        /// 批量取消仪表盘授权
        /// </summary>
        [XmlArray("dashboard_ids")]
        [XmlArrayItem("string")]
        public List<string> DashboardIds { get; set; }
    }
}
