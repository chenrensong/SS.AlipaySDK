using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayFundTransAuctionBalanceQueryResponse.
    /// </summary>
    public class AlipayFundTransAuctionBalanceQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前可用余额
        /// </summary>
        [XmlElement("balance_available")]
        public string BalanceAvailable { get; set; }

        /// <summary>
        /// 冻结金额
        /// </summary>
        [XmlElement("balance_freezed")]
        public string BalanceFreezed { get; set; }
    }
}
