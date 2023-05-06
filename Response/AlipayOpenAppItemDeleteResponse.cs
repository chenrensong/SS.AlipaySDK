using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenAppItemDeleteResponse.
    /// </summary>
    public class AlipayOpenAppItemDeleteResponse : AopResponse
    {
        /// <summary>
        /// 删除成功的商家侧商品ID和支付宝平台侧商品ID列表
        /// </summary>
        [XmlArray("records")]
        [XmlArrayItem("item_spu_id_pair")]
        public List<ItemSpuIdPair> Records { get; set; }
    }
}
