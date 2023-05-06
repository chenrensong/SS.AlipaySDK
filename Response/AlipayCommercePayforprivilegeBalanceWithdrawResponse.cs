using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommercePayforprivilegeBalanceWithdrawResponse.
    /// </summary>
    public class AlipayCommercePayforprivilegeBalanceWithdrawResponse : AopResponse
    {
        /// <summary>
        /// 提现流水号
        /// </summary>
        [XmlElement("withdraw_id")]
        public string WithdrawId { get; set; }
    }
}
