using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiMarketingDataMallRecommendGetResponse.
    /// </summary>
    public class KoubeiMarketingDataMallRecommendGetResponse : AopResponse
    {
        /// <summary>
        /// 是否还有更多数据：true-是，false-否
        /// </summary>
        [XmlElement("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 商圈商品券结构商圈商
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("item_resp")]
        public List<ItemResp> Items { get; set; }
    }
}
