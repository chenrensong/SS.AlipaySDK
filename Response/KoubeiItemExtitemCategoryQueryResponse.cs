using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiItemExtitemCategoryQueryResponse.
    /// </summary>
    public class KoubeiItemExtitemCategoryQueryResponse : AopResponse
    {
        /// <summary>
        /// 品类信息列表
        /// </summary>
        [XmlArray("category_list")]
        [XmlArrayItem("ext_category")]
        public List<ExtCategory> CategoryList { get; set; }
    }
}
