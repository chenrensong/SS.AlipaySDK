using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayEcoCmsCdataUploadResponse.
    /// </summary>
    public class AlipayEcoCmsCdataUploadResponse : AopResponse
    {
        /// <summary>
        /// 投放消息ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }
    }
}
