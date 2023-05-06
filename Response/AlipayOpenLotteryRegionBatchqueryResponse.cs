using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenLotteryRegionBatchqueryResponse.
    /// </summary>
    public class AlipayOpenLotteryRegionBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 商家入驻专区列表
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
