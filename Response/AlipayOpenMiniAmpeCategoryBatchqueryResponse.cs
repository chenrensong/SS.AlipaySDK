using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenMiniAmpeCategoryBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniAmpeCategoryBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 可选行业列表
        /// </summary>
        [XmlArray("category_list")]
        [XmlArrayItem("ampe_category_info")]
        public List<AmpeCategoryInfo> CategoryList { get; set; }
    }
}
