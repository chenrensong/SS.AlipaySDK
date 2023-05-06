using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMerchantPayforprivilegeUselogBatchqueryResponse.
    /// </summary>
    public class AlipayMerchantPayforprivilegeUselogBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 余额使用记录
        /// </summary>
        [XmlArray("use_log_list")]
        [XmlArrayItem("pay_for_privilege_recharge_card_use_log")]
        public List<PayForPrivilegeRechargeCardUseLog> UseLogList { get; set; }
    }
}
