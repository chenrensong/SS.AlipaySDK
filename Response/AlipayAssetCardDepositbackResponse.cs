using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayAssetCardDepositbackResponse.
    /// </summary>
    public class AlipayAssetCardDepositbackResponse : AopResponse
    {
        /// <summary>
        /// 退款金额
        /// </summary>
        [XmlElement("depositback_amount")]
        public string DepositbackAmount { get; set; }

        /// <summary>
        /// 退款交易号
        /// </summary>
        [XmlElement("depositback_bill_no")]
        public string DepositbackBillNo { get; set; }
    }
}
