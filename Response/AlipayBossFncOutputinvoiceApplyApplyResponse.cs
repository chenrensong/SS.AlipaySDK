using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayBossFncOutputinvoiceApplyApplyResponse.
    /// </summary>
    public class AlipayBossFncOutputinvoiceApplyApplyResponse : AopResponse
    {
        /// <summary>
        /// 开票申请ID，唯一
        /// </summary>
        [XmlElement("result_set")]
        public string ResultSet { get; set; }
    }
}
