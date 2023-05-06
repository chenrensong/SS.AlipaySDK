using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// MybankCreditLoanapplyUserlistUploadResponse.
    /// </summary>
    public class MybankCreditLoanapplyUserlistUploadResponse : AopResponse
    {
        /// <summary>
        /// 请求是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
