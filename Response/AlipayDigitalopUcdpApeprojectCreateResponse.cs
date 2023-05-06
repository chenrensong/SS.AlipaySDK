using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDigitalopUcdpApeprojectCreateResponse.
    /// </summary>
    public class AlipayDigitalopUcdpApeprojectCreateResponse : AopResponse
    {
        /// <summary>
        /// 新创建的projectID
        /// </summary>
        [XmlElement("project_id")]
        public long ProjectId { get; set; }
    }
}
