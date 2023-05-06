using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerbaseinfoListQueryResponse.
    /// </summary>
    public class AlipayOpenMiniInnerbaseinfoListQueryResponse : AopResponse
    {
        /// <summary>
        /// 小程序列表
        /// </summary>
        [XmlElement("mini_app_list")]
        public MiniAppBaseInfoQueryResponse MiniAppList { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
