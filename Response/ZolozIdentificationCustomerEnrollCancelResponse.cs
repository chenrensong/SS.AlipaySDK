using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// ZolozIdentificationCustomerEnrollCancelResponse.
    /// </summary>
    public class ZolozIdentificationCustomerEnrollCancelResponse : AopResponse
    {
        /// <summary>
        /// 与入参值保持一致
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }
    }
}
