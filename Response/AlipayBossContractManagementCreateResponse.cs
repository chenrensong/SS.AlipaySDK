using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayBossContractManagementCreateResponse.
    /// </summary>
    public class AlipayBossContractManagementCreateResponse : AopResponse
    {
        /// <summary>
        /// 发起审批返回结果
        /// </summary>
        [XmlElement("result_set")]
        public InterTradeStartContractApprovalResult ResultSet { get; set; }
    }
}
