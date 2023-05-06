using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenMiniAutocheckCaseCreateResponse.
    /// </summary>
    public class AlipayOpenMiniAutocheckCaseCreateResponse : AopResponse
    {
        /// <summary>
        /// 用例ID
        /// </summary>
        [XmlElement("case_id")]
        public string CaseId { get; set; }
    }
}
