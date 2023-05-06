using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AntMerchantExpandFrontcategorySecurityQueryResponse.
    /// </summary>
    public class AntMerchantExpandFrontcategorySecurityQueryResponse : AopResponse
    {
        /// <summary>
        /// 前台类目列表
        /// </summary>
        [XmlArray("front_category_list")]
        [XmlArrayItem("front_category_info")]
        public List<FrontCategoryInfo> FrontCategoryList { get; set; }
    }
}
