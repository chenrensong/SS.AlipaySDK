using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// MybankCreditSupplychainWfProductloanableamtQueryResponse.
    /// </summary>
    public class MybankCreditSupplychainWfProductloanableamtQueryResponse : AopResponse
    {
        /// <summary>
        /// 可贷额度列表
        /// </summary>
        [XmlArray("storeloanablelist")]
        [XmlArrayItem("mca_store_loanable_detail")]
        public List<McaStoreLoanableDetail> Storeloanablelist { get; set; }
    }
}
