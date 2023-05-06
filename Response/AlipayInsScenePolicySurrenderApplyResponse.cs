using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayInsScenePolicySurrenderApplyResponse.
    /// </summary>
    public class AlipayInsScenePolicySurrenderApplyResponse : AopResponse
    {
        /// <summary>
        /// 蚂蚁保险平台生成的保单号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }
    }
}
