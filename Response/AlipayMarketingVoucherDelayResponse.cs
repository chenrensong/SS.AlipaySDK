using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMarketingVoucherDelayResponse.
    /// </summary>
    public class AlipayMarketingVoucherDelayResponse : AopResponse
    {
        /// <summary>
        /// 被延期的券
        /// </summary>
        [XmlElement("voucher")]
        public OpenVoucherDTO Voucher { get; set; }
    }
}
