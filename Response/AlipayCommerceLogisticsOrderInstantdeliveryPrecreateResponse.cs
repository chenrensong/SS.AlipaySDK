using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsOrderInstantdeliveryPrecreateResponse.
    /// </summary>
    public class AlipayCommerceLogisticsOrderInstantdeliveryPrecreateResponse : AopResponse
    {
        /// <summary>
        /// 即时配送运单列表
        /// </summary>
        [XmlArray("waybills")]
        [XmlArrayItem("pre_create_waybill_istd")]
        public List<PreCreateWaybillIstd> Waybills { get; set; }
    }
}
