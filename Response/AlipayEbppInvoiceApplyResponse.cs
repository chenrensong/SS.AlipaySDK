using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayEbppInvoiceApplyResponse.
    /// </summary>
    public class AlipayEbppInvoiceApplyResponse : AopResponse
    {
        /// <summary>
        /// 支付宝返回的发票申请id,该id具有唯一性
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }
    }
}
