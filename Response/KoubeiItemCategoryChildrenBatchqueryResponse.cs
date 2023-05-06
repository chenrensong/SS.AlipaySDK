using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiItemCategoryChildrenBatchqueryResponse.
    /// </summary>
    public class KoubeiItemCategoryChildrenBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 口碑标准后台类目信息列表
        /// </summary>
        [XmlArray("category_list")]
        [XmlArrayItem("standard_category_info")]
        public List<StandardCategoryInfo> CategoryList { get; set; }
    }
}
