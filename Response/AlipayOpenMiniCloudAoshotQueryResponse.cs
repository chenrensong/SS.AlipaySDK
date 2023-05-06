using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenMiniCloudAoshotQueryResponse.
    /// </summary>
    public class AlipayOpenMiniCloudAoshotQueryResponse : AopResponse
    {
        /// <summary>
        /// 结果的总条数
        /// </summary>
        [XmlElement("item_total_count")]
        public string ItemTotalCount { get; set; }

        /// <summary>
        /// 热搜的item结果列表
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("aos_hot_item")]
        public List<AosHotItem> Result { get; set; }

        /// <summary>
        /// 请求的traceid，用于排查问题
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
