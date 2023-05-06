using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiRetailExtitemShopextitemQueryResponse.
    /// </summary>
    public class KoubeiRetailExtitemShopextitemQueryResponse : AopResponse
    {
        /// <summary>
        /// 标品详情列表
        /// </summary>
        [XmlArray("extitem_detail_list")]
        [XmlArrayItem("extitem_detail_info")]
        public List<ExtitemDetailInfo> ExtitemDetailList { get; set; }

        /// <summary>
        /// 记录总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
