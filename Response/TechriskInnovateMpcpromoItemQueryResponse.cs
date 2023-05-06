using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// TechriskInnovateMpcpromoItemQueryResponse.
    /// </summary>
    public class TechriskInnovateMpcpromoItemQueryResponse : AopResponse
    {
        /// <summary>
        /// 商品推荐查询结果
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("item_query_info")]
        public List<ItemQueryInfo> ItemList { get; set; }
    }
}
