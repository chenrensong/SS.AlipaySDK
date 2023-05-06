using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayAccountCashpoolDetailQueryResponse.
    /// </summary>
    public class AlipayAccountCashpoolDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 资金池详情，包含规则组信息、规则信息、账户关联信息
        /// </summary>
        [XmlElement("cash_pool_detail")]
        public string CashPoolDetail { get; set; }
    }
}
