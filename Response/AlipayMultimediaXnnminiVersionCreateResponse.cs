using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMultimediaXnnminiVersionCreateResponse.
    /// </summary>
    public class AlipayMultimediaXnnminiVersionCreateResponse : AopResponse
    {
        /// <summary>
        /// 版本信息标识id
        /// </summary>
        [XmlElement("version_id")]
        public string VersionId { get; set; }
    }
}
