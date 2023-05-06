using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AntMerchantExpandItemOpenBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandItemOpenBatchqueryModel : AopObject
    {
        /// <summary>
        /// 商品ID列表，单次查询上限为 20。
        /// </summary>
        [XmlArray("item_id_list")]
        [XmlArrayItem("string")]
        public List<string> ItemIdList { get; set; }
    }
}
