using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayFincoreFunddsAccountlogWitnessQueryResponse.
    /// </summary>
    public class AlipayFincoreFunddsAccountlogWitnessQueryResponse : AopResponse
    {
        /// <summary>
        /// 账户流水列表
        /// </summary>
        [XmlArray("accounting_log_list")]
        [XmlArrayItem("accounting_log_v_o")]
        public List<AccountingLogVO> AccountingLogList { get; set; }
    }
}
