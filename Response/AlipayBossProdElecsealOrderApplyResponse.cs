using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayBossProdElecsealOrderApplyResponse.
    /// </summary>
    public class AlipayBossProdElecsealOrderApplyResponse : AopResponse
    {
        /// <summary>
        /// 法务中台电子用印流水号
        /// </summary>
        [XmlElement("seal_request_id")]
        public string SealRequestId { get; set; }
    }
}
