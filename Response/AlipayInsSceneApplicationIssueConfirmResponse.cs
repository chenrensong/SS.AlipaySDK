using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayInsSceneApplicationIssueConfirmResponse.
    /// </summary>
    public class AlipayInsSceneApplicationIssueConfirmResponse : AopResponse
    {
        /// <summary>
        /// 投保订单号
        /// </summary>
        [XmlElement("application_no")]
        public string ApplicationNo { get; set; }
    }
}
