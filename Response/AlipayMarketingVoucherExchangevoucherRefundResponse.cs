using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMarketingVoucherExchangevoucherRefundResponse.
    /// </summary>
    public class AlipayMarketingVoucherExchangevoucherRefundResponse : AopResponse
    {
        /// <summary>
        /// 被冲正的券
        /// </summary>
        [XmlElement("voucher")]
        public OpenVoucherDTO Voucher { get; set; }
    }
}
