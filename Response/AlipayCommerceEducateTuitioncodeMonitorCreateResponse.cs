using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceEducateTuitioncodeMonitorCreateResponse.
    /// </summary>
    public class AlipayCommerceEducateTuitioncodeMonitorCreateResponse : AopResponse
    {
        /// <summary>
        /// 监管户名称
        /// </summary>
        [XmlElement("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 监管户号
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }
    }
}
