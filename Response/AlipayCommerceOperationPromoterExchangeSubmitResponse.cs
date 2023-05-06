using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceOperationPromoterExchangeSubmitResponse.
    /// </summary>
    public class AlipayCommerceOperationPromoterExchangeSubmitResponse : AopResponse
    {
        /// <summary>
        /// 积分兑换奖品处理结果
        /// </summary>
        [XmlElement("exchange_order_result")]
        public ExchangeOrderInfo ExchangeOrderResult { get; set; }
    }
}
