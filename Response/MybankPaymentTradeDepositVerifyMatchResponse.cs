using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// MybankPaymentTradeDepositVerifyMatchResponse.
    /// </summary>
    public class MybankPaymentTradeDepositVerifyMatchResponse : AopResponse
    {
        /// <summary>
        /// 金额是否匹配
        /// </summary>
        [XmlElement("valid")]
        public bool Valid { get; set; }
    }
}
