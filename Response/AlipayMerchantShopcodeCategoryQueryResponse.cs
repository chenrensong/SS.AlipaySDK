using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMerchantShopcodeCategoryQueryResponse.
    /// </summary>
    public class AlipayMerchantShopcodeCategoryQueryResponse : AopResponse
    {
        /// <summary>
        /// 门店码一级类目列表
        /// </summary>
        [XmlArray("categories")]
        [XmlArrayItem("category_root_d_t_o")]
        public List<CategoryRootDTO> Categories { get; set; }
    }
}
