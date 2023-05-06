using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiMallScanpurchasePreorderQueryResponse.
    /// </summary>
    public class KoubeiMallScanpurchasePreorderQueryResponse : AopResponse
    {
        /// <summary>
        /// 预订单信息
        /// </summary>
        [XmlElement("advance_order")]
        public AdvanceOrder AdvanceOrder { get; set; }
    }
}
