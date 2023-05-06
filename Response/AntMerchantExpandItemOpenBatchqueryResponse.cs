using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AntMerchantExpandItemOpenBatchqueryResponse.
    /// </summary>
    public class AntMerchantExpandItemOpenBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 商品列表。
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("cm_item_info")]
        public List<CmItemInfo> ItemList { get; set; }
    }
}
