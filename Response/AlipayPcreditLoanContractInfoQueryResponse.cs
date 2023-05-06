using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayPcreditLoanContractInfoQueryResponse.
    /// </summary>
    public class AlipayPcreditLoanContractInfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 合同内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }
    }
}
