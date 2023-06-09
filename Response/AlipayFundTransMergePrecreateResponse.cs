using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayFundTransMergePrecreateResponse.
    /// </summary>
    public class AlipayFundTransMergePrecreateResponse : AopResponse
    {
        /// <summary>
        /// 合并转账单据号
        /// </summary>
        [XmlElement("merge_order_id")]
        public string MergeOrderId { get; set; }
    }
}
