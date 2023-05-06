using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayTradeCreditFinanceRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeCreditFinanceRefundModel : AopObject
    {
        /// <summary>
        /// 本次需要退款的金额，单位为元；精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 币种单位，目前只支持人民币CNY
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 扩展参数，格式为json字符串。
        /// </summary>
        [XmlElement("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 退款备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 外部退款请求号，外部请求号，用于支付宝内部做幂等控制。同一笔trade_no下out_request_no不能相同，如果相同则代表是重复请求
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 收款人信息
        /// </summary>
        [XmlElement("payee_info")]
        public CreditFinancePayAccountInfo PayeeInfo { get; set; }

        /// <summary>
        /// 本次金融付款对应交易的买家ID
        /// </summary>
        [XmlElement("trade_buyer_id")]
        public string TradeBuyerId { get; set; }

        /// <summary>
        /// 需要进行金融退款处理的交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
