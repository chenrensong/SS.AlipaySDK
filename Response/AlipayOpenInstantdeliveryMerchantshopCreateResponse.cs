using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenInstantdeliveryMerchantshopCreateResponse.
    /// </summary>
    public class AlipayOpenInstantdeliveryMerchantshopCreateResponse : AopResponse
    {
        /// <summary>
        /// 门店创建返回的结果。
        /// </summary>
        [XmlArray("logistics_shop_status")]
        [XmlArrayItem("logistics_shop_status_d_t_o")]
        public List<LogisticsShopStatusDTO> LogisticsShopStatus { get; set; }
    }
}
