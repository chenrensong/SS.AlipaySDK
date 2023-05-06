using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceEcServiceOrderBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceEcServiceOrderBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 服务订购单列表
        /// </summary>
        [XmlArray("service_order_base_info_list")]
        [XmlArrayItem("service_order_base_info")]
        public List<ServiceOrderBaseInfo> ServiceOrderBaseInfoList { get; set; }
    }
}
