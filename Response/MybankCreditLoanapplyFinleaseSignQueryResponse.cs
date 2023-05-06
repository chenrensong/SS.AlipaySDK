using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// MybankCreditLoanapplyFinleaseSignQueryResponse.
    /// </summary>
    public class MybankCreditLoanapplyFinleaseSignQueryResponse : AopResponse
    {
        /// <summary>
        /// 签约结果。json字符串
        /// </summary>
        [XmlElement("msg_content")]
        public string MsgContent { get; set; }
    }
}
