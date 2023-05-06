using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiMerchantGoodsSyncResponse.
    /// </summary>
    public class AlipayPcreditHuabeiMerchantGoodsSyncResponse : AopResponse
    {
        /// <summary>
        /// 业务处理成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
