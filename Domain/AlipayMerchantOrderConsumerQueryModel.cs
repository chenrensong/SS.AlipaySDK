using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayMerchantOrderConsumerQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantOrderConsumerQueryModel : AopObject
    {
        /// <summary>
        /// 业务号（目前仅支持交易号）    注：  1. order_id、biz_no、两者必选其一，若用biz_no查询，必须传入buyer_id  2.若都传，优先级order_id>biz_no，忽略优先级低的字段
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 买家支付宝用户id    注：若用biz_no查询，必须传入buyer_id
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 支付宝订单号    注：  1. order_id、biz_no、两者必选其一，若用biz_no查询，必须传入buyer_id  2.若都传，优先级order_id>biz_no，忽略优先级低的字段
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
