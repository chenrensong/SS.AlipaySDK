using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiRetailWmsBatchinventoryQueryResponse.
    /// </summary>
    public class KoubeiRetailWmsBatchinventoryQueryResponse : AopResponse
    {
        /// <summary>
        /// 库存信息列表
        /// </summary>
        [XmlArray("inventory_list")]
        [XmlArrayItem("inventory")]
        public List<Inventory> InventoryList { get; set; }
    }
}
