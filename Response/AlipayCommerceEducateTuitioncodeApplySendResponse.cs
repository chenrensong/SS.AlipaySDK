using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceEducateTuitioncodeApplySendResponse.
    /// </summary>
    public class AlipayCommerceEducateTuitioncodeApplySendResponse : AopResponse
    {
        /// <summary>
        /// 申请id
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }
    }
}
