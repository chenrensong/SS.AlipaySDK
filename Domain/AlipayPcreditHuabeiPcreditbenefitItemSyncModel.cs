using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiPcreditbenefitItemSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiPcreditbenefitItemSyncModel : AopObject
    {
        /// <summary>
        /// 商品列表
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("singltem")]
        public List<Singltem> ItemList { get; set; }
    }
}
