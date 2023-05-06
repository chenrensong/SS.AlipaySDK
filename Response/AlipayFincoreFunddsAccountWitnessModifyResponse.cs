using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayFincoreFunddsAccountWitnessModifyResponse.
    /// </summary>
    public class AlipayFincoreFunddsAccountWitnessModifyResponse : AopResponse
    {
        /// <summary>
        /// 账号
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }
    }
}
