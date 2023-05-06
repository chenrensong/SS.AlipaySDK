using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenSpMerchantInconsistentApproveResponse.
    /// </summary>
    public class AlipayOpenSpMerchantInconsistentApproveResponse : AopResponse
    {
        /// <summary>
        /// 申请单据编号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }
    }
}
