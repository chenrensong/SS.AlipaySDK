using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenMiniCategoryRequireQueryResponse.
    /// </summary>
    public class AlipayOpenMiniCategoryRequireQueryResponse : AopResponse
    {
        /// <summary>
        /// 类目对应资质列表
        /// </summary>
        [XmlArray("category_require_info_list")]
        [XmlArrayItem("category_require_info")]
        public List<CategoryRequireInfo> CategoryRequireInfoList { get; set; }
    }
}
