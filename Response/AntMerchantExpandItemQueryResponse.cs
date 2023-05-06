using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AntMerchantExpandItemQueryResponse.
    /// </summary>
    public class AntMerchantExpandItemQueryResponse : AopResponse
    {
        /// <summary>
        /// 商品列表
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("item_model")]
        public List<ItemModel> ItemList { get; set; }
    }
}
