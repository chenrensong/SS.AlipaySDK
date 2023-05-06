using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenSearchBrandcatalogBatchqueryResponse.
    /// </summary>
    public class AlipayOpenSearchBrandcatalogBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 品牌下可用类目
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("catalog_node_data")]
        public List<CatalogNodeData> Data { get; set; }
    }
}
