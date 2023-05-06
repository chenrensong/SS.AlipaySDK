using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayBossFncUserinvoiceinfoCreateResponse.
    /// </summary>
    public class AlipayBossFncUserinvoiceinfoCreateResponse : AopResponse
    {
        /// <summary>
        /// 开票资料id，唯一性ID
        /// </summary>
        [XmlElement("result_set")]
        public string ResultSet { get; set; }
    }
}
