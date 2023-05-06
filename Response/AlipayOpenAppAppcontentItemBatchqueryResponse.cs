using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenAppAppcontentItemBatchqueryResponse.
    /// </summary>
    public class AlipayOpenAppAppcontentItemBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 商品信息
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("app_content_item")]
        public List<AppContentItem> Items { get; set; }
    }
}
