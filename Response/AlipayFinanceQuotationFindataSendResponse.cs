using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayFinanceQuotationFindataSendResponse.
    /// </summary>
    public class AlipayFinanceQuotationFindataSendResponse : AopResponse
    {
        /// <summary>
        /// 是否投递成功
        /// </summary>
        [XmlElement("send_result")]
        public bool SendResult { get; set; }
    }
}
