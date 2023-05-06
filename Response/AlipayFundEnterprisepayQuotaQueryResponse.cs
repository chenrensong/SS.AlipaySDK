using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayFundEnterprisepayQuotaQueryResponse.
    /// </summary>
    public class AlipayFundEnterprisepayQuotaQueryResponse : AopResponse
    {
        /// <summary>
        /// 额度详情信息列表
        /// </summary>
        [XmlArray("quota_list")]
        [XmlArrayItem("joint_account_quota_resp_d_t_o")]
        public List<JointAccountQuotaRespDTO> QuotaList { get; set; }
    }
}
