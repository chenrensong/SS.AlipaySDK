using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenIotbpaasMerchantorderQueryResponse.
    /// </summary>
    public class AlipayOpenIotbpaasMerchantorderQueryResponse : AopResponse
    {
        /// <summary>
        /// 订单列表
        /// </summary>
        [XmlArray("order_list")]
        [XmlArrayItem("io_t_b_paa_s_merchant_order_info")]
        public List<IoTBPaaSMerchantOrderInfo> OrderList { get; set; }
    }
}
