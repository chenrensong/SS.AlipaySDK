using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayBossFncOutputinvoiceOutbillApplyResponse.
    /// </summary>
    public class AlipayBossFncOutputinvoiceOutbillApplyResponse : AopResponse
    {
        /// <summary>
        /// 开票申请ID，唯一
        /// </summary>
        [XmlElement("result_set")]
        public string ResultSet { get; set; }
    }
}
