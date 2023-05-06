using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenMiniMiniappHistoryQueryResponse.
    /// </summary>
    public class AlipayOpenMiniMiniappHistoryQueryResponse : AopResponse
    {
        /// <summary>
        /// 小程序最近使用记录列表
        /// </summary>
        [XmlArray("mini_app_history_infos")]
        [XmlArrayItem("mini_app_history_info")]
        public List<MiniAppHistoryInfo> MiniAppHistoryInfos { get; set; }
    }
}
