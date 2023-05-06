using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceReceiptSendResponse.
    /// </summary>
    public class AlipayCommerceReceiptSendResponse : AopResponse
    {
        /// <summary>
        /// 商品列表中有对应的环保类型时，需要返回
        /// </summary>
        [XmlArray("order_goods_list")]
        [XmlArrayItem("environment_info")]
        public List<EnvironmentInfo> OrderGoodsList { get; set; }
    }
}
