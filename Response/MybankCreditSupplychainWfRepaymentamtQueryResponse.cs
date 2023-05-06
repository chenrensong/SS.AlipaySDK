using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// MybankCreditSupplychainWfRepaymentamtQueryResponse.
    /// </summary>
    public class MybankCreditSupplychainWfRepaymentamtQueryResponse : AopResponse
    {
        /// <summary>
        /// 总余额，单位分 出账前：只有本金，不包含利息 出账后及逾期后：包含本金+利息+罚息 （原因：只有出账后才会对账单进行结息）
        /// </summary>
        [XmlElement("totalbalance")]
        public AmountWf Totalbalance { get; set; }
    }
}
