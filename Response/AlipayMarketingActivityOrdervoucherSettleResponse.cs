using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMarketingActivityOrdervoucherSettleResponse.
    /// </summary>
    public class AlipayMarketingActivityOrdervoucherSettleResponse : AopResponse
    {
        /// <summary>
        /// 用于查询结算单号
        /// </summary>
        [XmlElement("settle_no")]
        public string SettleNo { get; set; }
    }
}
