using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayEbppInvoiceExpenserulesProjectrulesModifyResponse.
    /// </summary>
    public class AlipayEbppInvoiceExpenserulesProjectrulesModifyResponse : AopResponse
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public string Success { get; set; }
    }
}
