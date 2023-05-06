using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayMarketingExchangevoucherUseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingExchangevoucherUseModel : AopObject
    {
        /// <summary>
        /// 业务上下文
        /// </summary>
        [XmlElement("biz_context")]
        public string BizContext { get; set; }

        /// <summary>
        /// 是否需要校验规则
        /// </summary>
        [XmlElement("need_rule_check")]
        public bool NeedRuleCheck { get; set; }

        /// <summary>
        /// 支付宝用户ID(映射的openId) ，必须保证待使用的券ID归属于该支付宝用户ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部业务号，用户幂等控制。相同voucher_id和out_biz_no被认为是同一次核销
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 支付宝用户ID ，必须保证待使用的券ID归属于该支付宝用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 待使用的券id ，来自发券接口alipay.marketing.voucher.send
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
