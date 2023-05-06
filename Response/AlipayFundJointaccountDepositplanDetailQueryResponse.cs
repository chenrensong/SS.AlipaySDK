using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayFundJointaccountDepositplanDetailQueryResponse.
    /// </summary>
    public class AlipayFundJointaccountDepositplanDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 资金计划列表
        /// </summary>
        [XmlArray("fund_plan_list")]
        [XmlArrayItem("fund_plan_d_t_o")]
        public List<FundPlanDTO> FundPlanList { get; set; }
    }
}
