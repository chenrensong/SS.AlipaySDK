using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenSpLeadsExpandCreateResponse.
    /// </summary>
    public class AlipayOpenSpLeadsExpandCreateResponse : AopResponse
    {
        /// <summary>
        /// 商机id
        /// </summary>
        [XmlElement("leads_id")]
        public string LeadsId { get; set; }
    }
}
