using System;
using System.Xml.Serialization;

namespace SS.AlipaySDKaySDK.Response
{
    /// <summary>
    /// AntMerchantExpandMembercardRefundSubmitResponse.
    /// </summary>
    public class AntMerchantExpandMembercardRefundSubmitResponse : AopResponse
    {
        /// <summary>
        /// 退款金额（单位：元）
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退款手续费（单位：元）
        /// </summary>
        [XmlElement("refund_fee")]
        public string RefundFee { get; set; }
    }
}
