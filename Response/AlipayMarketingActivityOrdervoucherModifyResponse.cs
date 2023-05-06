using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMarketingActivityOrdervoucherModifyResponse.
    /// </summary>
    public class AlipayMarketingActivityOrdervoucherModifyResponse : AopResponse
    {
        /// <summary>
        /// 可用范围结果
        /// </summary>
        [XmlElement("voucher_available_scope_result_info")]
        public VoucherAvailableScopeResultInfo VoucherAvailableScopeResultInfo { get; set; }

        /// <summary>
        /// 核销规则请求结果
        /// </summary>
        [XmlElement("voucher_use_rule_result")]
        public OrderVoucherUseRuleResult VoucherUseRuleResult { get; set; }
    }
}
